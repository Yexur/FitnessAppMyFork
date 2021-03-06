﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FitnessApp.Logic;
using System.Threading.Tasks;

namespace FitnessApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IAnnouncementLogic _announcementLogic;

        public HomeController(IAnnouncementLogic announcementLogic)
        {
            _announcementLogic = announcementLogic;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _announcementLogic.GetList());
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }
    }
}
