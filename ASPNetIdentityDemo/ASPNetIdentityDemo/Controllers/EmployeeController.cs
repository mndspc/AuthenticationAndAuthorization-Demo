using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetIdentityDemo.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        // GET: Employee
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateProfile()
        {
            return View();
        }
    }
}