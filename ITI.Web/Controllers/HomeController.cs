using ITI.Models;
using ITI.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly InstituteRepository instituteRepository;
        public HomeController()
        {
            instituteRepository = new InstituteRepository();
        } 

        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Institute()
        {
            InstituteDetailModel instituteDetailModel = new InstituteDetailModel();
            var model = instituteRepository.GetInstitute().FirstOrDefault();
            if(model!=null)
            {
                instituteDetailModel.ID = model.ID;
                instituteDetailModel.Name = model.Name;
                instituteDetailModel.RegNo = model.RegNo;
                instituteDetailModel.CertficateLink = model.CertficateLink; 
            }
            return View(instituteDetailModel);
        }
        public ActionResult Home()
        {
            var model = new List<NewsTableModel>();
            return View(model);
        }
        public ActionResult Defult()
        {
            return View();
        }
    }
}