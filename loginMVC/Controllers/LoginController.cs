using loginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class LoginController : Controller
    {
        MvcUserDataEntities db = new MvcUserDataEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(MyLogin l)
        {
            var query = db.UserRegisters.SingleOrDefault(m => m.Email == l.Email && m.Password == l.Password);
            if (query != null)
            {
                Response.Write("<script>alert('Login Successful')</script>");
            }
            else
            {
                Response.Write("<script>alert('Login unsuccessful.. Try again!!!')</script>");
            }
            return View();
        }
    }
}