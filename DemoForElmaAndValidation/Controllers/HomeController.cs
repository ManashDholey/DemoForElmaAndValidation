using System;
using System.Web.Mvc;
using HandleErrorAttribute = DemoForElmaAndValidation.Error.HandleErrorAttribute;

namespace DemoForElmaAndValidation.Controllers
{
    [HandleErrorAttribute]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            //throw new Exception("Text exception"); 
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}