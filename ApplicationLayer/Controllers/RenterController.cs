using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationLayer.Controllers
{
    public class RenterController : Controller
    {
        RenterRepository repo = new RenterRepository();
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                return View(repo.GetAll());
            }
            else
            {
                
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Renter emp)
        {
            if (ModelState.IsValid)
            {
                repo.Insert(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }

        public ActionResult Details(int id)
        {
            return View(repo.Get(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Renter emp)
        {
            if (ModelState.IsValid)
            {
                repo.Update(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repo.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }
        
            [HttpPost]
            public ActionResult Logout()
            {
                Session.Abandon();
                return RedirectToAction("Login","Login");
            
        }
    }
}