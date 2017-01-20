using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dentist.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.Controllers
{
    public class ServicesController : Controller
    {
        private DentistContext db = new DentistContext();

        public Service Service { get; private set; }

        public IActionResult Index()
        {
            return View(db.Services.ToList());
        }
        // GET: /<controller>/
        public IActionResult Details(int id)
        {
            var thisService = db.Services.FirstOrDefault(ServicesController => ServicesController.ServiceId == id);
            return View(thisService);
        }
    }
}
