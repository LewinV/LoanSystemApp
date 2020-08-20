using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoanSystemApp.Models;
using LoanSystemApp.Persistence.Repositories.Interfaces;
using WebUI.Controllers;
using Application.Tasks.Commands;

namespace LoanSystemApp.Controllers
{
    public class HomeController : MVCController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITasksRepository _tasksRepository;

        public HomeController(ILogger<HomeController> logger, ITasksRepository tasksRepository)
        {
            _logger = logger;
            _tasksRepository = tasksRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult<int>> AddTask(CreateTaskCommand command)
        {
            return await Mediator.Send(command);
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
