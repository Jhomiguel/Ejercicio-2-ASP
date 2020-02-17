using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPEjercicio2.Models;

namespace ASPEjercicio2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ArrayNum());
        }
        [HttpPost]
            public IActionResult Index(ArrayNum arrayNum)
            {
                if (ModelState.IsValid)
                {
                    arrayNum.Nmayor = ArrayNum.Omayor(arrayNum.ArrayNums);
                    arrayNum.Nmenor = ArrayNum.Omenor(arrayNum.ArrayNums);
                    return View("Mostrar", arrayNum);
                }

                return View(arrayNum);
            }

    }
}
