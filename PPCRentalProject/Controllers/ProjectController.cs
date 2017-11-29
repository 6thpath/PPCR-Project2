using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRentalProject.Models;
using PagedList;
using PPCRentalProject.ViewModels;


namespace PPCRentalProject.Controllers
{
    public class ProjectController : Controller
    {
        DemoPPCRentalEntities entities = new DemoPPCRentalEntities();
        // GET: Project
       

        public ActionResult ProjectDetail(int id)
        {
            var ProD = entities.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(ProD);
        }

        [HttpGet]
        public ActionResult Search(string text)
        {
            var data = entities.PROPERTies.Where(x => x.PropertyName.Contains(text));
            return View(data);
        }
    }
}