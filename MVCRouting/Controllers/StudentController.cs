using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouting.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //[ActionName("StudentsList")]
        public ActionResult Index()
        {
            return View();
        }
        public string Index1(int id)
        {
            return $"Student Controller - Index method id : {id}";
        }
        

    }
}