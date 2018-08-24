using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Health_Application.Models;
using Microsoft.AspNet.Identity;

namespace Health_Application.Controllers
{
    [Authorize]
    public class DataController : Controller
    {
        protected ApplicationDbContext db { get; set; }

        public DateTime today = DateTime.Now.Date; 


        public DataController()
        {
            db = new ApplicationDbContext();

        }
        
        // GET: Recorder
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult LogData(UserData data)
        {
            var id = User.Identity.GetUserId();
            var user = db.Users.Single(c => c.Id == id);
            //DateTime today = DateTime.Now.Date;
            var userdata = db.UserDatas.FirstOrDefault(c => c.Date == today && c.User.Id == id);
            if (userdata == null)
            {
                data.User = user;
                data.Date = today;
                db.UserDatas.Add(data);
            }
            else
            {
                userdata.ProteinIntake = data.ProteinIntake;
                userdata.CarbonIntake = data.CarbonIntake;
                userdata.FatIntake = data.FatIntake;
                userdata.CalorieIntake = data.CalorieIntake;
                //userdata.Date = data.Date;
                userdata.CalorieComsumption = data.CalorieComsumption;
                userdata.Distance = data.Distance;
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Chart()
        {
            DateTime endDate = today.AddDays(15);
            List<float> protein = new List<float>();
            List<float> carbon = new List<float>();
            List<float> fat = new List<float>();
            List<float> carlorieIn = new List<float>();
            List<float> carlorieOut = new List<float>();
            List<float> distance = new List<float>();
            IQueryable<UserData> userdata = db.UserDatas.Where(c => c.Date >= today && c.Date <= endDate);
            foreach(var data in userdata)
            {
                protein.Add(data.ProteinIntake);
                carbon.Add(data.CarbonIntake);
                fat.Add(data.FatIntake);
                carlorieIn.Add(data.CalorieIntake);
                carlorieOut.Add(data.CalorieComsumption);
                distance.Add(data.Distance);
            }
            var total = protein.Sum() + carbon.Sum() + fat.Sum();
            var proteinPer = protein.Sum()/total;
            var carbonPer = carbon.Sum() / total;
            var fatPer = fat.Sum() / total;
            ViewBag.protein = proteinPer*100;
            ViewBag.carbon = carbonPer*100;
            ViewBag.fat = fatPer*100;


            return View();
        }
    }
}