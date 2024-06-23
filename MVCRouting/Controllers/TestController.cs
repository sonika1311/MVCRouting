using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCRouting.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "Test Controller - Index Method";
        }
        public string Show()
        {
            return "Test Controller - Show method";
        }
    }
}