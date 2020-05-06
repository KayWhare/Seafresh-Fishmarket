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
    public class SeafreshStoreController : Controller
    {
        private readonly ShopAppContext _context;

        public SeafreshStoreController(ShopAppContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                PopulateViewData(Convert.ToInt32(cartIdCookie));
            }
            else
            {
                PopulateViewData(null);
            }

            return View();
        }
        [HttpGet]
        public IActionResult Quickview()
        {

            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                PopulateShopData(Convert.ToInt32(cartIdCookie));
            }
            else
            {
                PopulateShopData(null);
            }

            return PartialView("_QuickviewCartPartial" );
        }

        [HttpGet("{category}")]
        public IActionResult Category(string category)
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                PopulateShopData(Convert.ToInt32(cartIdCookie));
            }
            else
            {
                PopulateShopData(null);
            }
            ViewData["Products"] = _context.Products.Where(p => p.Category == category).ToList();

            
            return View("index");
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

                PopulateViewData(cart.Id);
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

                PopulateViewData(cartId);
            }

            return View();

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
        private void PopulateViewData(int? cartId)
        {
            // fetch all products
            ViewData["Products"] = _context.Products.ToList();
            PopulateShopData(cartId);
        }
    }
}
