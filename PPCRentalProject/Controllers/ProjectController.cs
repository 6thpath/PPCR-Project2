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
            var ProD = entities.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(ProD);
        }

        public ActionResult Sale_ProjectsList(int? page)
        {
            ViewModel Vm = new ViewModel();
            Vm.zDistricts = entities.DISTRICTs.ToList();
            Vm.zWards = entities.WARDs.ToList();
            Vm.zStreets = entities.STREETs.ToList();
            Vm.zProperties = entities.PROPERTies.ToList();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(Vm.zProperties.ToPagedList(pageNumber, pageSize));
        }
        
        [HttpGet]
        public ActionResult Sale_EditProject(int id)
        {
            var proj = entities.PROPERTies.FirstOrDefault(x => x.ID == id);
            ViewBag.Property_Type = entities.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.StreetName = entities.STREETs.ToList();
            ViewBag.WardName = entities.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.DistrictName = entities.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            return View(proj);
        }

        [HttpPost]
        public ActionResult Sale_EditProject(int id,PROPERTY p)
        {
            var Ei = entities.PROPERTies.FirstOrDefault(x => x.ID == id);
            Ei.Avatar = p.Avatar;
            Ei.Images = p.Images;
            Ei.PropertyName = p.PropertyName;
            Ei.PropertyType_ID = p.PropertyType_ID;
            Ei.Area = p.Area;
            Ei.BedRoom = p.BedRoom;
            Ei.BathRoom = p.BathRoom;
            Ei.PackingPlace = p.PackingPlace;
            Ei.DISTRICT = p.DISTRICT;
            Ei.WARD = p.WARD;
            Ei.STREET = p.STREET;
            Ei.Content = p.Content;
            Ei.Status_ID = p.Status_ID;
            Ei.Note = p.Note;
            entities.SaveChanges();
            return RedirectToAction("Sale_ProjectsList");
        }
    }
}