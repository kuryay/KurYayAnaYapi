using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KurYayAnaYapi.DataAccessLayer.Concrete;
using KurYayAnaYapi.Models.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KurYayAnaYapi.Controllers
{
    public class YonetimController : Controller
    {

        InformationOperations informationOperations = new InformationOperations("Information");

        public IActionResult Index()
        {
            /*
            - Ekleme Testi 
            Information information = new Information("Berke Kurnaz", "contact@berkekurnaz.com", "Berkekurnaz", "berkekurnazsubtitle", "berkekurnazdescription");
            informationOperations.AddModel(information);
            */
            return View();
        }

    }
}