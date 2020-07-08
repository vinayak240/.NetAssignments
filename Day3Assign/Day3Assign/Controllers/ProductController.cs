using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day3Assign.Models;

namespace Day3Assign.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> list = new List<Product>() {
        new Product(){pid="1001", pname="Mobile", price=12000, stock=40},
        new Product(){pid="1002", pname="TV", price=20000, stock=10}
        };
        public IActionResult Index()
        {
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            list.Add(p);
            return RedirectToAction("Index");
        }

    }
}
