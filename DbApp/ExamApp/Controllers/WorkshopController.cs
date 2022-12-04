using ExamApp.DAL;
using ExamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondWorkshop.Controllers
{
    public class WorkshopController : Controller
    {
        WorkshopContext workshopContext = new WorkshopContext();
        // GET: Workshop
        public ActionResult Index()
        {
            List<Workshop> workshops = workshopContext.Workshops.ToList();
            ViewBag.list = workshops;
            return View();
        }

        // GET: Workshop/Details/5
        public ActionResult Details(int id)
        {
            Workshop workshop = workshopContext.Workshops.Find(id);
            ViewBag.workshop = workshop;
            return View();
        }

        // GET: Workshop/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshop/Create
        [HttpPost]
        public ActionResult Create( string topic, string desc, string present, string location)
        {
            Workshop workshop = new Workshop {Topic = topic, Description = desc, Faculty = present, Location = location };
            try
            {
                workshopContext.Workshops.Add(workshop);
                workshopContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            Workshop workshop = workshopContext.Workshops.Find(id);
            ViewBag.workshop = workshop;
            return View();
        }

        // POST: Workshop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,  string topic, string desc, string present, string location)
        {
            Workshop workshop = workshopContext.Workshops.Find(id);
            try
            {
                workshop.Topic = topic;
                workshop.Description = desc;
                workshop.Faculty = present;
                workshop.Location = location;
                workshopContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            Workshop workshop = workshopContext.Workshops.Find(id);
            workshopContext.Workshops.Remove(workshop);
            workshopContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}