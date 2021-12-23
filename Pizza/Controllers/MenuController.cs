using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public MenuController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult menu()
        {
            return View();
        }
    }
}
