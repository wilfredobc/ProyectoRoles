using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SoporteEnLinea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoporteEnLinea.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var idUsuarioActual = User.Identity.GetUserId();
            return View();
        }

        [Authorize(Roles = "NombreDelRole, NombreDelOtroRole")]
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
    }
}