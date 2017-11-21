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
        public ActionResult User_ViewProjectList(int? page)
        {
            ViewModel Vm = new ViewModel();
            Vm.zDistricts = entities.DISTRICTs.ToList();
            Vm.zWards = entities.WARDs.ToList();
            Vm.zStreets = entities.STREETs.ToList();
            Vm.zProperties = entities.PROPERTies.ToList();
            //var Vm = entities.PROPERTies.ToList();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(Vm.zProperties.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult ProjectDetail(int id)
        {
            var detail = entities.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(detail);
        }
    }
}