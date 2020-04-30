using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Controllers
{
    public class FileController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new Exception("File empty!");
            }

            var appDataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory");
            var filePath = Path.Combine(appDataDirectory.ToString(), file.FileName);
            using (var stream = System.IO.File.Create(filePath))
            {
                file.CopyTo(stream);
            } // stream.Dispose();

            return View();
        }


    }
}
