using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GermanProject.Models;
using Microsoft.AspNet.Mvc;

namespace GermanProject.Controllers
{
    public class HomeController : Controller
    {
        private IApplicationRepository _repository;

        public HomeController(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var chapters = _repository.GetAllChapters();
            return View(chapters);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
