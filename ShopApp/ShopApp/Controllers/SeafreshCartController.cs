using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Data;

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

            return View("Cart");
        }


    }
}
