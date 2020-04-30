using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopApp.Data;
using ShopApp.Models;
using Stripe;

namespace ShopApp.Controllers
{
    public class CartController : BaseController
    {
        private readonly ShopAppContext _context;

        public CartController(ShopAppContext context)
            : base(context)
        {
            _context = context;
        }


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

            var cartItems = (List<CartItem>) ViewData["CartItems"];
            var totalAmount = cartItems.Sum(ci => ci.Quantity * ci.Product.Price);
            //decimal totalAmount = 0;
            //foreach (var cartItem in cartItems)
            //{
            //    var itemTotal = cartItem.Quantity * cartItem.Product.Price;
            //    totalAmount = totalAmount + itemTotal;
            //}

            // Set your secret key. Remember to switch to your live secret key in production!
            // See your keys here: https://dashboard.stripe.com/account/apikeys
            StripeConfiguration.ApiKey = "sk_test_2VH9I2XjnubbxPyiLOQR7VMJ";

            var options = new PaymentIntentCreateOptions
            {
                Amount = Convert.ToInt64(totalAmount * 100),
                Currency = "aud",
            };

            var service = new PaymentIntentService();
            var paymentIntent = service.Create(options);

            ViewData["ClientSecret"] = paymentIntent.ClientSecret;

            return View();
        }

        private void PopulateViewData(int productId, int? cartId)
        {
            // fetch all products
            PopulateShopData(cartId);
        }
    }
}