using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ExamOnline.Models;
using ExamOnlineClient.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnlineClient.Controllers
{
    public class ExaminationsController : Controller
    {
        readonly HttpClient client = new HttpClient
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

        public IActionResult LoadEmployee()
        {
            List<EmployeeVM> employees = null;
            List<EmployeeVM> trainees = new List<EmployeeVM>();
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            API.DefaultRequestHeaders.Add("Authorization", HttpContext.Session.GetString("JWToken"));
            var resTask = API.GetAsync("users");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<EmployeeVM>>();
                readTask.Wait();
                employees = readTask.Result;
                foreach (var employee in employees)
                {
                    if (employee.roleName == "Trainee")
                    {
                        trainees.Add(employee);
                    }
                }
            }
            else
            {
                trainees = null;
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(trainees);
        }
                
        public IActionResult LoadExamination()
        {
            IEnumerable<Examination> examnations = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("examinations");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<Examination>>();
                readTask.Wait();
                examnations = readTask.Result;
            }
            else
            {
                examnations = Enumerable.Empty<Examination>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(examnations);
        }

        public IActionResult GetById(string Id)
        {
            Examination examination = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("examinations/" + Id);
            resTask.Wait();
            //HttpContext.Session.SetInt32("joblists", Id);
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                examination = JsonConvert.DeserializeObject<Examination>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(examination);
        }

        public IActionResult InsertOrUpdate(Examination examination, string id)
        {
            try
            {
                var json = JsonConvert.SerializeObject(examination);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //var token = HttpContext.Session.GetString("token");
                //client.DefaultRequestHeaders.Add("Authorization", token);
                if (examination.Id == null)
                {
                    var result = client.PostAsync("examinations", byteContent).Result;
                    return Json(result);
                }
                else if (examination.Id == id)
                {
                    var result = client.PutAsync("examinations/" + id, byteContent).Result;
                    return Json(result);
                }

                return Json(404);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Delete(string id)
        {
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var result = client.DeleteAsync("examinations/" + id).Result;
            return Json(result);
        }
    }
}