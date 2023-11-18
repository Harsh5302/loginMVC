using loginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class RegistrationController : Controller
    {
        MvcUserDataEntities db = new MvcUserDataEntities(); 
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserRegister ur)
        {
            db.UserRegisters.Add(ur);
            db.SaveChanges();
            Response.Write("<script>alert('Registration Successful')</script>");
            return View();
        }
    }
    
}