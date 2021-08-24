using M2E1NETCore_MVC_Hello.Areas.Marketing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace M2E1NETCore_MVC_Hello.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsWithViewModel()
        {
            var products = GetProductsJsonLocal();
            return View(products);
        }

        public IActionResult ProductsWithViewBag()
        {
            var products = GetProductsJsonLocal();
            ViewBag.ProductList = products;
            ViewBag.MyName = "Luis";
            return View();
        }

        public IActionResult ProductsWithViewData() 
        {
            var products = GetProductsJsonLocal();
            ViewData["ProductList"] = products;
            ViewData["MyName"] = "Alberto";
            return View();
        }


        public List<Product> GetProductsJsonLocal()
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Areas\\Marketing\\data\\products.json");

            var json = System.IO.File.ReadAllText(folder);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }


    }

}

