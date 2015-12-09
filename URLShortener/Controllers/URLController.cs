using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using URLShortener.Models.DAL;

namespace URLShortener.Controllers
{
    public class URLController : Controller
    {
        Data data = new Data();

        // GET: URL
        public ActionResult Index(string NewURL, int APIKey)
        {
            ViewBag.Message = NewURL + " " + APIKey.ToString();
            return View();
        }

        public bool CheckAPI(string strAPI)
        {
            return data.CheckAPIKey(strAPI);
        }
    }
}