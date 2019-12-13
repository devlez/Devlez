using HopeEntities;
using HopeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HopeUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<News> list = new NewsServices().GetNews();
            return View();
        }
    }
}