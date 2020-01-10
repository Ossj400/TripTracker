using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripTracker.UI.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class AccountController : Controller
    {
        public string Index()
        {
            return "Hello from admin area";
        }
    }
}