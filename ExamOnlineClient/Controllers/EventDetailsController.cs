using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExamOnlineClient.Controllers
{
    public class EventDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
