using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSandersMVC.Models;

namespace CSandersMVC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration /
        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationModel obj)
        {
            return View();
        }
    }
}