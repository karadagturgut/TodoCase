using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TodoCase.DataAccess.Services.IServices;
using TodoCase.Models;

namespace TodoCase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITaskService _taskService;
        private readonly IPersonService _personService;

        public HomeController(ILogger<HomeController> logger, ITaskService taskService, IPersonService personService)
        {
            _logger = logger;
            _taskService = taskService;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var person = _personService.GetAll();
            var task = _taskService.GetAll();
            return View(person);
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
