using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Models.ViewModel;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly LaborDbContext db = null;
        public HomeController(LaborDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var data = db.LaborWorks.Select(x => Map(x)).ToList();
            //return View(db.LaborWorks.ToList());
            return View(data);
        }
        private LaborWorkVM Map(LaborWork l)
        {
            return new LaborWorkVM
            {
                Id = l.Id,
                LobarName = l.LobarName,
                PayRate=l.PayRate,
                StartDate=l.StartDate,
                FinishDate=l.FinishDate

            };
        }
    }
}
