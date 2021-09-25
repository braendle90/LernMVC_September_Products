using LernMVC_September.Data;
using LernMVC_September.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LernMVC_September.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {


            IEnumerable<Product> Products = _context.Products.Where(x => x.Producer == x.Producer).ToArray();

            
            



            return View(Products);
        }
    }
}
