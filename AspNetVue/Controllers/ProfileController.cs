using AspNetVue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetVue.Controllers
{
    public class ProfileController : Controller
    {

        // GET: Profile
        public ActionResult Index()
        {
            ProfileVM profile = new ProfileVM();

            return View(profile);
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}