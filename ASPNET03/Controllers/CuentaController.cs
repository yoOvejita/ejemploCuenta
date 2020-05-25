using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET03.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            if (name.Equals("admin") && password.Equals("admin"))
            {
                Session["username"] = name;
                return View("Success");
            }
            else {
                ViewBag.error = "Usuario y/o password inválido";
                return View("Index");
            }
            
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}