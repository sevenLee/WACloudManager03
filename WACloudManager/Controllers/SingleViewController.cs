using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WACloudManager.Controllers
{
    public class SingleViewController : Controller
    {
        // GET: SingleView
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult DeviceManagement()
        {
            return View();
        }

        public ActionResult TagGroup()
        {
            return View();
        }
    }
}