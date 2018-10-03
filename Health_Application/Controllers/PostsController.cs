using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Health_Application.Models;
using Health_Application.PostsViewModel;
using Microsoft.AspNet.Identity;

namespace Health_Application.Controllers
{
    public class PostsController : Controller
    {
        protected ApplicationDbContext db { get; set; }

        public PostsController()
        {
            db = DbContextFactory.GetCurrentDbContext();

        }

        // GET: Posts
        public ActionResult Index()
        {
            var posts = db.Post.Include(p => p.User).Include(p=>p.Response).ToList();
            return View(posts);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Post.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            TempData["id"] = id;
            return View(post);
        }

        [HttpPost]
        public ActionResult Reply(PostViewModel model)
        {
            var id = User.Identity.GetUserId();
            var user = db.Users.Single(c => c.Id == id);
            DateTime now = DateTime.Now;
            var postid = (int)TempData["id"];

            //Response response = new Response();
            //response = model.Response;
            //response.User = user;
            //response.Time = now;
            //temp.Response.Add(response);
            Response newResponse = new Response
            {
                Id = 1,
                PostId = postid,
                User = user,
                Time = DateTime.Now,
                Message = model.PostResponse.Message
            };
            Post post = db.Post.Find(postid);
            post.Response.Add(newResponse);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        // GET: Posts/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Body")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Post.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Post.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Body")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Post.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Post.Find(id);
            db.Post.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
