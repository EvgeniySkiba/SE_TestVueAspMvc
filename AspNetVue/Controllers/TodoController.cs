using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetVue.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Conputed()
        {
            return View();
        }

        public ActionResult Watchers()
        {
            return View();
        }

        public ActionResult CheckBox()
        {
            return View();
        }
    }
}