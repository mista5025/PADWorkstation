using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RplProgramDocument_List.Controllers
{
    public class CreateNewController : Controller
    {

        public IActionResult SectionInfo()
        {
            return View();
        }
        public IActionResult CreateSectionOne()
        {
            return View();
        }

        public IActionResult CreateSectionTwo()
        {
            return View();
        }

        public IActionResult CreateSectionThree()
        {
            return View();
        }

        public IActionResult CreateSectionFour()
        {
            return View();
        }

        public IActionResult CreateSectionFive()
        {
            return View();
        }
    }
}