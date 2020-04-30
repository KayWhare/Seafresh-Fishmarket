using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopApp.Common;
using ShopApp.Data;
using ShopApp.Models;

namespace ShopApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ShopAppContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ShopAppContext context)
            : base(context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // check the CART_ID cookie to see if the user has an existing cart
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                // if so, cast the cartId string into an int and provide it to the PopulateViewData method
                PopulateViewData(Convert.ToInt32(cartIdCookie));
            }
            else
            {
                // no cart, so pass null for the cartId
                PopulateViewData(null);
            }

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(CartItem item)
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (!ModelState.IsValid)
            {
                // there is a model error
                if (cartIdCookie == null)
                {
                    PopulateViewData(null);
                }
                else
                {
                    PopulateViewData(Convert.ToInt32(cartIdCookie));
                }
                return View();
            }
            
            if (cartIdCookie == null)
            {
                // need to create a new cart
                var cart = new Cart();

                cart.CartItems = new List<CartItem>();
                cart.CartItems.Add(item);

                var userId = GetEncryptedShopCookie("USER_ID");
                if (userId != null)
                {
                    cart.UserId = Convert.ToInt32(userId);
                }

                // add the cart to the context, then apply the changes to the database via the SaveChanges method
                _context.Add(cart);
                _context.SaveChanges();

                // set the cartId in a cookie
                SetEncryptedShopCookie("CART_ID", cart.Id.ToString());

                // we are going to show the user the Index.cshtml view, so populate the ViewData values
                PopulateViewData(cart.Id);
            }
            else
            {
                // already has a cart so fetch from database
                var cartId = Convert.ToInt32(cartIdCookie);

                // fetch the cart from the database
                var cart = _context.Carts
                    .Include(c => c.CartItems)
                    .SingleOrDefault(c => c.Id == cartId);

                if (cart == null)
                {
                    return NotFound();
                }

                // get the existing cart item, if any
                var cartItem = cart.CartItems
                    .SingleOrDefault(ci => ci.ProductId == item.ProductId);

                // add new item to cart or replace quantity on an existing item
                if (cartItem == null)
                {
                    // new item
                    cart.CartItems.Add(item);
                }
                else
                {
                    // update existing item
                    if (item.Quantity == 0)
                    {
                        // delete
                        _context.Remove(cartItem);
                    }
                    else
                    {
                        // update
                        cartItem.Quantity = item.Quantity;
                        _context.Update(cartItem);
                    }
                }

                _context.SaveChanges();

                PopulateViewData(cartId);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(CartItem item)
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                // already has a cart so fetch from database
                var cartId = Convert.ToInt32(cartIdCookie);

                // fetch the cart from the database
                var cart = _context.Carts
                    .Include(c => c.CartItems)
                    .SingleOrDefault(c => c.Id == cartId);

                if (cart != null)
                {
                    // get the existing cart item, if any
                    var cartItem = cart.CartItems
                        .SingleOrDefault(ci => ci.ProductId == item.ProductId);

                    // add new item to cart or replace quantity on an existing item
                    if (cartItem != null)
                    {
                        _context.Remove(cartItem);
                        _context.SaveChanges();
                    }
                }
            }

            if (cartIdCookie == null)
            {
                PopulateViewData(null);
            }
            else
            {
                PopulateViewData(Convert.ToInt32(cartIdCookie));
            }

            ModelState.ClearValidationState("Quantity");

            return View("Index");
        }

        private void PopulateViewData(int? cartId)
        {
            // fetch all products
            ViewData["Products"] = _context.Products.ToList();
            PopulateShopData(cartId);
        }
    }
}
