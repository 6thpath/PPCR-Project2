using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PPCRentalProject.Models;

namespace PPCRentalProject.Controllers
{
    public class HomeController : Controller
    {
        DemoPPCRentalEntities entities = new DemoPPCRentalEntities();
        public ActionResult Index()
        {
            var props = entities.PROPERTies.ToList();
            //int pageSize = 6;
            //int pageNumber = (page ?? 1);
            return View(props/*props.ToPagedList(pageNumber, pageSize)*/);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}