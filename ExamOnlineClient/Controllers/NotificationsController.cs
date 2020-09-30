using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExamOnline.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnlineClient.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44376/api/")
        };
        readonly HttpClient API = new HttpClient
        {
            BaseAddress = new Uri("http://winarto-001-site1.dtempurl.com/api/")
        };
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult LoadNotif()
        //{
        //    IEnumerable<Notifications> question = null;
        //    //var token = HttpContext.Session.GetString("token");
        //    //client.DefaultRequestHeaders.Add("Authorization", token);
        //    var resTask = client.GetAsync("notifications");
        //    resTask.Wait();

        //    var result = resTask.Result;
        //    if (result.IsSuccessStatusCode)
        //    {
        //        var readTask = result.Content.ReadAsAsync<List<Notifications>>();
        //        readTask.Wait();
        //        question = readTask.Result;
        //    }
        //    else
        //    {
        //        question = Enumerable.Empty<Notifications>();
        //        ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
        //    }
        //    return Json(question);

        //}

        public IActionResult LoadNotif(string id)
        {
            id = HttpContext.Session.GetString("id");
            Notifications notifications = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("notifications/notif/" + id);
            resTask.Wait();
            //HttpContext.Session.SetInt32("joblists", Id);
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Notifications>();
                readTask.Wait();

                notifications = readTask.Result;
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(notifications);
        }

    }
}