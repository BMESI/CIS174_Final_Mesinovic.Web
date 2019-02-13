using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    public class CheckersController : Controller
    {
        // GET: Checkers
        public ActionResult CheckersPage()
        {
            return View();
        }
    }
}