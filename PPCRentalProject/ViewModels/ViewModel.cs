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
    }
}