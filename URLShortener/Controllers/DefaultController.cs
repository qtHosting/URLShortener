using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using URLShortener.Models.DAL;

namespace URLShortener.Controllers
{
    public class DefaultController : Controller
    {
        Data data = new Data();
        // GET: Default
        public ActionResult Index(string LinkID)
        {
            if (!String.IsNullOrEmpty(LinkID))
            {
                string strURL = GetURLFromShortID(LinkID);

                return Redirect("strURL");
            }
            else
            {
                return View();
            }
        }

        public string GetURLFromShortID(string strShortID)
        {
            return data.GetURLFromShortID(strShortID, Request.UserHostAddress);
        }
    }
}