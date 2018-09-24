using DataLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationLayer.Controllers
{
    public class AdvertisementController : Controller
    {
        //
        // GET: /Advertisement/
        OwnerRepository repo = new OwnerRepository();
        DataContext db = new DataContext();
        public ActionResult Index(string serachBy, string search)
        {
            if (serachBy == "name")
            {
                return View(db.Owners.Where(x => x.Name==search || search==null).ToList());
            }
            else if(serachBy=="area"){
                return View(db.Owners.Where(y => y.Area==search || search == null).ToList());
            }
           // else if(searchBy=="all")
           // {
           //// var b=db.Owners.Where(a=>a.Area)
           //     return View(db.Owners.Where(x=>x.Name==search));
           // }
            return View(repo.GetAll());
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            
            return View(repo.GetAll());
        }
        [HttpPost]
        public ActionResult Details(Renter id)
        {
            OwnerRepository repo = new OwnerRepository();
            DataContext db = new DataContext();
            Owner dbO=new Owner();

        

            return View(id);
        }
        
	}
}