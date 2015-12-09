using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace URLShortener.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(string LinkID)
        {
            return View();
        }
    }
}