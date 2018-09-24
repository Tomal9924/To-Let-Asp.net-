using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationLayer.Controllers
{
    public class OwnerController : Controller
    {
        OwnerRepository repo = new OwnerRepository();
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                return View(repo.GetAll());
            }
            else {
                return RedirectToAction("Login","Login");
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Owner post)
        {
            if (ModelState.IsValid)
            {
                repo.Insert(post);
                return RedirectToAction("Index");
            }
            else
            {
                return View(post);
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
        public ActionResult Edit(Owner post)
        {
            if (ModelState.IsValid)
            {
                repo.Update(post);
                return RedirectToAction("Index");
            }
            else
            {
                return View(post);
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
    }
}