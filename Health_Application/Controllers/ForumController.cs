using Health_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Health_Application.Controllers
{
    public class ForumController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Forum
        public ActionResult Index()
        {
            IQueryable<Post> post = db.Posts;
            ViewBag.Model = post;
            return View();
        }
    }

}
