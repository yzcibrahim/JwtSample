using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult IndexJson()
        {
            //HttpCookie cookie = new HttpCookie("Token", access_token);
            //cookie.Expires = DateTime.Now.AddDays(-1);

            //HttpContext.Response.Cookies.Append()

            //SignIn(Request.HttpContext.User);
            return Json(new { asd="asd" });
        }

        public IActionResult Auth()
        {
            
            //Request.HttpContext.Request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InN0cmluZyIsInJvbGUiOiJhZG1pbiIsIm5iZiI6MTY1MjEwOTgzOCwiZXhwIjoxNjUyMTEzNDM4LCJpYXQiOjE2NTIxMDk4Mzh9.HK-blS91dgR2JByIb13vjBADp-ap0aveHl9CgAW6lyA");
            HttpContext.Response.Cookies.Append("mYkeyToken", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InN0cmluZyIsInJvbGUiOiJhZG1pbiIsIm5iZiI6MTY1MjEwOTgzOCwiZXhwIjoxNjUyMTEzNDM4LCJpYXQiOjE2NTIxMDk4Mzh9.HK-blS91dgR2JByIb13vjBADp-ap0aveHl9CgAW6lyA");
            return Json(new { token = "asd" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}
