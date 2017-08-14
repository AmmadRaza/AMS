using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AMS.Controllers
{
    public class HomeController : Controller
    {
        TaskEntities db = new TaskEntities();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            TaskEntities db = new TaskEntities();
            var list = db.TblStudents.ToList();
            ViewBag.record = list;
            
            return View();
        }

        [HttpPost]
        public ActionResult List(TblAttendance am, string Date, int[] StudentId)
        {

            for (int i = 0; i < StudentId.Length; i++)
            {
                am.S_Id = StudentId[i];

                db.TblAttendances.Add(am);
                db.SaveChanges();
            }

            return Content("Done");
        } 
    }
}
