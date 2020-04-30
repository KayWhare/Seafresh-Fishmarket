using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApp.Common;
using ShopApp.Data;
using ShopApp.Models;

namespace ShopApp.Controllers
{
    public class BaseController : Controller
    {

        private readonly ShopAppContext _context;

        public BaseController(ShopAppContext context)
        {
            _context = context;
        }


        protected void SetEncryptedShopCookie(string cookieKey, string cookieValue)
        {
            var cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.MaxValue;

            var encryptedCookieContent = EncryptionHelper.EncryptString(cookieValue, EncryptionHelper.EncryptionKey);

            HttpContext.Response.Cookies.Append(cookieKey, encryptedCookieContent, cookieOptions);
        }

        protected string GetEncryptedShopCookie(string cookieKey)
        {
            var encryptedShopCookie = HttpContext.Request.Cookies[cookieKey];

            if (encryptedShopCookie == null)
            {
                return null;
            }

            var cookieContent = EncryptionHelper.DecryptString(encryptedShopCookie, EncryptionHelper.EncryptionKey);

            return cookieContent;
        }

        protected void PopulateShopData(int? cartId)
        {
            var userId = GetEncryptedShopCookie("USER_ID");
            if (userId != null)
            {
                var user = _context.Users.Find(Convert.ToInt32(userId));
                if (user != null)
                {
                    ViewData["LoggedInName"] = $"{user.FirstName} {user.LastName}";
                }
            }

            if (cartId.HasValue)
            {
                // user has a cart so fetch all cartItems belonging to their cart only
                ViewData["CartItems"] = _context.CartItems
                    .Include(ci => ci.Product)
                    .Where(ci => ci.CartId == cartId)
                    .ToList();
            }
            else
            {
                // ensure the cartItems collection is not null (just so we don't have to check for null in the view)
                ViewData["CartItems"] = new List<CartItem>();
            }
        }

    }
}