using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPCRentalProject.Models;
using PagedList;

namespace PPCRentalProject.ViewModels
{
    public class ViewModel
    {
        public List<DISTRICT> zDistricts { get; set; }
        public List<PROPERTY> zProperties { get; set; } 
        public List<STREET> zStreets { get; set; }
        public List<WARD> zWards { get; set; }
        public List<USER> zUsers { get; set; }
        public List<FEATURE> zFeatures { get; set; }
        public List<PROJECT_STATUS> zProjectStatus { get; set; }
        public List<PROPERTY_FEATURE> zPropertyFeatures { get; set; }
        public List<PROPERTY_TYPE> zPropertytype { get; set; }
    }
}