using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopApp.Data;
using ShopApp.Models;

namespace ShopApp.Controllers
{
    public class ProductController : BaseController
    {
        private readonly ShopAppContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, ShopAppContext context)
            : base(context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            // product listing view...


            throw new NotImplementedException();
        }

        public IActionResult Details(int id)
        {
            var cartIdCookie = GetEncryptedShopCookie("CART_ID");

            if (cartIdCookie != null)
            {
                // if so, cast the cartId string into an int and provide it to the PopulateViewData method
                PopulateViewData(id, Convert.ToInt32(cartIdCookie));
            }
            else
            {
                // no cart, so pass null for the cartId
                PopulateViewData(id, null);
            }

            return View();
        }
        
        private void PopulateViewData(int productId, int? cartId)
        {
            // fetch all products
            ViewData["Product"] = _context.Products.Find(productId);
            PopulateShopData(cartId);
        }
    }
}