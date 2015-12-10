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
        public ActionResult Index(string NewURL, string APIKey)
        {
            if(CheckAPI(APIKey))
            {
                
            }

            ViewBag.Message = NewURL + " " + APIKey.ToString();
            return View();
        }

        public ActionResult GetAPI()
        {
            return View();
        }

        public ActionResult SubmitAPIApplication(FormCollection form)
        {
            return View();
        }

        public bool CheckAPI(string strAPI)
        {
            return data.CheckAPIKey(strAPI);
        }

        public string SubmitNewURL(string strNewURL)
        {
            return data.GetNewShortID(strNewURL, Request.UserHostAddress);
        }
    }
}