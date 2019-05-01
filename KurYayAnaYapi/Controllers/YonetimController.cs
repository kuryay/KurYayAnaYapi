using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KurYayAnaYapi.Controllers
{
    public class YonetimController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}