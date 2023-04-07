using LtmApp.Web.ApiServices.Interfaces;
using LtmApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LtmApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseApiService apiService;

        public HomeController(ILogger<HomeController> logger, ICourseApiService apiService)
        {
            _logger = logger;
            this.apiService = apiService;
        }

        public async Task<IActionResult>  Index()
        {
            var course = await this.apiService.GetCourses();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
