﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            ViewData["Products"] = _context.Products.ToList();

            return View();
        }

        [HttpGet("{category}")]
        public IActionResult Category(string category)
        {
            ViewData["Products"] = _context.Products.Where(p => p.Category == category).ToList();

            return View("index");
        }
    }
}
