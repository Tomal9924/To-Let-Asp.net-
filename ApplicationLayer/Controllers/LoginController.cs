using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationLayer.Controllers
{
    public class LoginController : Controller
    {
        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Login(Owner objRenter,string loginBy)
        {
            if (loginBy == "owner")
            {

                using (DataContext db = new DataContext())
                {
                    var obj = db.Owners.Single(a => a.Username.Equals(objRenter.Username) && a.Password.Equals(objRenter.Password));
                    if (obj != null)
                    {
                        //session["userid"] = obj.userid.tostring();
                        Session["Id"] = obj.Id.ToString();
                        // ModelState.AddModelError("", "login data is incorrect!");
                        
                        return RedirectToAction("Index", "Owner");
                    }
                    else
                    {
                        ModelState.AddModelError("","login data is incorrect!");
                        
                        return RedirectToAction("Login", "Login");
                    }
                }
            }
            else if(loginBy=="renter")
            { 
                    using (DataContext db = new DataContext())
                     {
                    var renterobj = db.Renters.Single(a => a.Username.Equals(objRenter.Username) && a.password.Equals(objRenter.Password));
                    if (renterobj != null)
                    {
                        //session["userid"] = obj.userid.tostring();
                        Session["Id"] = renterobj.Id.ToString();
                        // ModelState.AddModelError("", "login data is incorrect!");
                        
                        return RedirectToAction("Index", "Renter");
                    }
                    else
                    {
                        ModelState.AddModelError("", "login data is incorrect!");
                        
                        return RedirectToAction("Login", "Login");

                         }
                    }
                }
            
            return View(objRenter);
            }
            
        }

        //public ActionResult UserDashBoard()
        //{

        //    if (Session["Id"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
        //}
    }  
