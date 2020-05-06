using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApp.Common;
using ShopApp.Data;
using ShopApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopApp.Controllers
{
    public class SeafreshCartController : Controller
    {

        private readonly ShopAppContext _context;

        public SeafreshCartController(ShopAppContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                // if so, cast the cartId string into an int and provide it to the PopulateViewData method
                PopulateShopData(Convert.ToInt32(cartIdCookie));
            }
            else
            {
                // no cart, so pass null for the cartId
                PopulateShopData(null);
            }


            var cartItems = (List<CartItem>)ViewData["CartItems"];

            var totalAmount = cartItems.Sum(ci => ci.Quantity * ci.Product.Price);

            return View("Cart");
        }
        [HttpPost]
        public IActionResult Delete(CartItem item)
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                var cartId = Convert.ToInt32(cartIdCookie);

                var cart = _context.Carts
                    .Include(c => c.CartItems)
                    .SingleOrDefault(c => c.Id == cartId);

                if (cart != null)
                {
                    var cartItem = cart.CartItems
                        .SingleOrDefault(ci => ci.ProductId == item.ProductId);

                    _context.Remove(cartItem);
                    _context.SaveChanges();
                }
            }
            if (cartIdCookie == null)
            {
                PopulateShopData(null);
            }
            else
            {
                PopulateShopData(Convert.ToInt32(cartIdCookie));
            }
            return View("Cart");
        }

        [HttpGet]
        public IActionResult UpdateCartView()
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie == null)
            {
                PopulateShopData(null);
            }
            else
            {
                PopulateShopData(Convert.ToInt32(cartIdCookie));
            }

            return PartialView("_CartItemPartial");
        }

        [HttpPost]
        public IActionResult Index(CartItem item)
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie == null)
            {
                var cart = new Cart();
                cart.CartItems = new List<CartItem>();
                cart.CartItems.Add(item);



                _context.Add(cart);
                _context.SaveChanges();

                SetEncryptedShopCookie("CART_ID", cart.Id.ToString());

                PopulateShopData(cart.Id);
            }
            else
            {
                var cartId = Convert.ToInt32(cartIdCookie);

                var cart = _context.Carts
                    .Include(c => c.CartItems)
                    .SingleOrDefault(c => c.Id == cartId);

                if (cart == null)
                {
                    return NotFound();
                }

                var cartItem = cart.CartItems
                    .SingleOrDefault(ci => ci.ProductId == item.ProductId);

                if (cartItem == null)
                {
                    cart.CartItems.Add(item);
                }
                else
                {
                    if (item.Quantity == 0)
                    {
                        _context.Remove(cartItem);
                    }
                    else
                    {
                        cartItem.Quantity = item.Quantity;
                        _context.Update(cartItem);
                    }
                }

                _context.SaveChanges();

                PopulateShopData(cartId);
            }

            return PartialView("_CartItemPartial");

        }
        protected void PopulateShopData(int? cartId)
        {
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


    }
}
