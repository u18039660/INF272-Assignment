using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTinder.Controllers
{
    public class JobSeekerController : Controller
    {
        // GET: JobSeeker
        public ActionResult JobSeekerLogin()
        {
            return View();
        }

        public ActionResult JobSeekerRegistration()
        {

            return View();
        }

        public ActionResult JobSeekerMatches()
        {

            return View();
        }

        public ActionResult JobSeekerProfile()
        {

            return View();
        }
    }
}