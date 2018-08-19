using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Health_Application.Controllers
{
    public class RecorderController : Controller
    {
        // GET: Recorder
        public ActionResult Index()
        {
            return View();
        }
    }
}