using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    public class WorkAreaController : Controller
    {
        //
        // GET: /WorkArea/

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Authentication auth = new Authentication();
                    if (auth.DoLogin(user.Username, user.Password))
                    {
                        return RedirectToAction("home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Login failed! Please check credentials");
                    }
                }
            }
            catch (Exception ex)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View();
        }

    }
}
