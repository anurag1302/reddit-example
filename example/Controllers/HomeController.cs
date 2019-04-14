using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using example.Models;
using example.Helpers;

namespace example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

        public IActionResult RedditExample()
        {
            var model = DataHelper.GetRedditExampleModel();
            model.AddModel = new RedditAddModel
            {
                Categories=DataHelper.GetCategories(),
                Applications=DataHelper.GetApplications()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult PostAddModel(RedditAddModel addModel)
        {
            var result = $"{addModel.Id}{"-"}{addModel.Title}{"-"}{addModel.SelectedCategory}{"-"}{addModel.SelectedApplication}";
            return Json(result);
        }
    }
}
