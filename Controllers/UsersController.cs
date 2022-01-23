using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVRWebsite_Unibit_5sem_MWT_MVC.Models;

namespace MVRWebsite_Unibit_5sem_MWT_MVC.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Authorize(User user)
        {
            using (MVR_WEBSITEEntities db = new MVR_WEBSITEEntities())
            {
                User existingUser = db.User.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                if(existingUser != null)
                {
                    Session["username"] = existingUser.Username;
                    Session["role"] = existingUser.Role;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View("Login");
                }
            }

            return View();
        }

        public ActionResult Logout(User user)
        {
            Session.Abandon();
            return RedirectToAction("Login", "Users");
        }
    }
}