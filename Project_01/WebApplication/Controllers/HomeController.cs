using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerDbContext db;
        public HomeController(CustomerDbContext db)
        {
            this.db = db;
        }
        
        public IActionResult Index()
        {
            return View(db.Customers.ToList());
        }
    }
}
