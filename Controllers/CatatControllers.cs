using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testmvc.Models;

namespace testmvc.Controllers
{
    public class CatatController : Controller
    {
        private readonly ILogger<CatatController> _logger;

        public CatatController(ILogger<CatatController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dapat([FromForm]DataSiswa result){
            ViewData["nama"] =  result.i_name;
            ViewData["email"] =  result.i_email;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class DataSiswa{
        public string i_email{get;set;}
        public string i_name{get;set;}
    }
}