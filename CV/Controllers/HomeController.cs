using CV.Interface;
using CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICvService _cv;
        private readonly ITaxCalculatorService _taxService;

        public HomeController(ICvService cvService,
                              ITaxCalculatorService taxService)
        {
            _cv = cvService;
            _taxService = taxService;
        }

        public IActionResult Index()
            => View(_cv.GetHomeInfo());

        public IActionResult About()
            => View(_cv.GetAboutInfo());

        public IActionResult Experience()
            => View(_cv.GetExperience());

        public IActionResult Projects()
            => View(_cv.GetProjects());

        public IActionResult Skills()
            => View(_cv.GetSkills());

        public IActionResult Education()
            => View(_cv.GetEducation());

        public IActionResult Contact()
            => View(_cv.GetContactInfo());

        [HttpGet]
        public IActionResult TaxCalculator()
            => View();

        [HttpPost]
        public IActionResult TaxCalculator(decimal salary)
        {
            ViewBag.Salary = salary;
            ViewBag.Tax = _taxService.Calculate(salary);
            return View();
        }
    }
}
