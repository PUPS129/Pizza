using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AboutController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult about()
        {
            return View();
        }
    }
}
