using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstProject.Controllers
{
    public class Home : Controller
    {
        public ViewResult Index() {
            return View("MyView");
        }
    }
}
