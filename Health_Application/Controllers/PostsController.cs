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
            var uid = User.Identity.GetUserId();
            //var user = db.Users.Single(c => c.Id == id);
            ViewData["userId"] = uid;
            return View(posts);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post ps = db.Post.Find(id);
            //eager load all objects
            Post post = db.Post.Include(p => p.Response.Select(u=>u.User)).Include(p => p.User).FirstOrDefault(p => p.Id == id);
            TempData["tempPost"] = post;
            TempData["id"] = id;
            if (post == null)
            {
                return HttpNotFound();
            };
            PostViewModel postViewModel = new PostViewModel();
            postViewModel.Post = post;
            return View(postViewModel);

        }

        [HttpPost]
        public ActionResult Reply(PostViewModel model)
        {
            var id = User.Identity.GetUserId();
            var user = db.Users.Single(c => c.Id == id);
            DateTime now = DateTime.Now;
            var postid = (int)TempData["id"];
            var post = db.Post.Find(postid);
            if (post.Response == null)
            {
                post.Response = new List<Response>();
            }
            //Response response = new Response();
            //response = model.Response;
            //response.User = user;
            //response.Time = now;
            //temp.Response.Add(response);
            Response newResponse = new Response
            {
                Id = 1,
                PostId = postid,
                Post = post,
                User = user,
                Time = DateTime.Now,
                Message = model.PostResponse.Message
            };

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
            var id = User.Identity.GetUserId();
            var user = db.Users.Single(c => c.Id == id);
            post.User = user;
            post.Time = DateTime.Now;
            post.Response = new List<Response>();
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
