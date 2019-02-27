using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RplProgramDocument_List.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return View();
        }
    }
}