using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Common;
using ShopApp.Data;
using ShopApp.Models;

namespace ShopApp.Controllers
{
    public class UserController : BaseController
    {

        private readonly ShopAppContext _shopAppContext;

        public UserController(ShopAppContext shopAppContext)
            : base(shopAppContext)
        {
            _shopAppContext = shopAppContext;
        }


        // Login read view
        // /User/
        public IActionResult Index()
        {
            return View();
        }

        // Login submit view
        // [POST] /User/
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            // lookup the user by email address
            var existingUser = _shopAppContext.Users.SingleOrDefault(u => u.EmailAddress == model.EmailAddress);
            if (existingUser == null)
            {
                ModelState.AddModelError("EmailAddress", "Either the email address or password was incorrect");
                return View();
            }

            // validate the incoming password with the password hash in the database
            var passwordVerified = BCrypt.Net.BCrypt.Verify(model.Password, existingUser.PasswordHash);

            if (!passwordVerified)
            {
                ModelState.AddModelError("EmailAddress", "Either the email address or password was incorrect");
                return View();
            }

            // if it matches, set a cookie with the userId
            SetEncryptedShopCookie("USER_ID", existingUser.Id.ToString());

            // redirect to Home
            return RedirectToAction("Index", "Home");
        }


        // Register read view
        // /User/Register
        public IActionResult Register()
        {
            return View();
        }

        // Register submit view
        // [POST] /User/Register
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            // check if email already exists in database (if so throw exception)
            var existingUser = _shopAppContext.Users.SingleOrDefault(u => u.EmailAddress == model.EmailAddress);

            if (existingUser != null)
            {
                ModelState.AddModelError("EmailAddress", "Email Address already exists in database");
                return View();
            }

            // hash the incoming password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);

            // create a new user record
            var user = new User();
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.EmailAddress = model.EmailAddress;
            user.PasswordHash = passwordHash;
            user.CreatedAt = DateTimeOffset.Now;

            try
            {
                _shopAppContext.Users.Add(user);
                _shopAppContext.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            // redirect to the login
            return RedirectToAction("Index");
        }

        // /User/Logout
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("USER_ID");
            HttpContext.Response.Cookies.Delete("CART_ID");
            return RedirectToAction("Index", "Home");
        }

    }
}