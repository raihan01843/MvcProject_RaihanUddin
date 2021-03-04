using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO;
using MvcProject_Raihan.Models;
using System.Data.Entity;

namespace MvcProject_Raihan.Controllers
{
    public class AutherController : Controller
    {
        // GET: Auther
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (MvcProject_Raihan01Entities db = new MvcProject_Raihan01Entities())
            {
                List<Auther> authertList = db.Authers.ToList<Auther>();
                return Json(new { data = authertList },
                JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult StoreOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Auther());
            else
            {
                using (MvcProject_Raihan01Entities db = new MvcProject_Raihan01Entities())
                {


                    return View(db.Authers.Where(x => x.AutherID == id).FirstOrDefault<Auther>());

                }
            }
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (MvcProject_Raihan01Entities db = new MvcProject_Raihan01Entities())
            {
                Auther emp = db.Authers.Where(x => x.AutherID == id).FirstOrDefault<Auther>();
                db.Authers.Remove(emp);
                db.SaveChanges();
                return Json(new { success = true, message = "Deleted Successfully", JsonRequestBehavior.AllowGet });
            }
        }

    }
}
