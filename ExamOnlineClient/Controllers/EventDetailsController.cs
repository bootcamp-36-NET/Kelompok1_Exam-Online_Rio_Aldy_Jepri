using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ExamOnline.Models;
using ExamOnlineClient.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnlineClient.Controllers
{
    public class EventDetailsController : Controller
    {
        List<EmployeeVM> trainees = new List<EmployeeVM>();
        List<EmployeeVM> employeeList = null;

        private readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44376/api/")
        };

        private readonly HttpClient API = new HttpClient
        {
            BaseAddress = new Uri("http://winarto-001-site1.dtempurl.com/api/")
        };

        [Route("/eventdetails")]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> Load()
        {
            List<EventDetailsVM> detailList = null;
            List<EmployeeVM> _trainees = new List<EmployeeVM>();
            List<EmployeeVM> traineesToView = new List<EmployeeVM>();

            string id = HttpContext.Session.GetString("id");
         
            var readTask = client.GetAsync("eventdetails/events/" + id);
            readTask.Wait();
            var result = readTask.Result;

            if(result.IsSuccessStatusCode)
            {
                var output = result.Content.ReadAsStringAsync().Result;
                detailList = JsonConvert.DeserializeObject<List<EventDetailsVM>>(output);

                _trainees = this.LoadAPI().Result;

                if (_trainees != null)
                {
                    foreach (var employee in _trainees)
                    {
                        foreach(var item in detailList)
                        {
                            if (employee.id == item.EmployeeId)
                            {
                                traineesToView.Add(employee);
                            }
                        }
                        
                    }
                }
                else
                {
                    traineesToView = null;
                    ModelState.AddModelError(string.Empty, "Error! Please try again");
                }
                return Json(traineesToView);
            }

            return Json(result.StatusCode);
        }

        public async Task<List<EmployeeVM>> LoadAPI()
        {
            API.DefaultRequestHeaders.Add("Authorization", HttpContext.Session.GetString("JWToken"));
            var resTask = API.GetAsync("users");
            resTask.Wait();
            var result = resTask.Result;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<EmployeeVM>>();
                readTask.Wait();
                employeeList = readTask.Result;
                foreach (var employee in employeeList)
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
                ModelState.AddModelError(string.Empty, "Error! Please try again");
            }
            return trainees;
        }

        public async Task<JsonResult> LoadEmployee(EmployeeVM employeeVM)
        {

            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);

            List<EmployeeVM> emp = null;
            emp = this.LoadAPI().Result;
            return Json(emp);

        }

        public async Task<JsonResult> Insert(string Id, EventDetails details)
        {
            var item = JsonConvert.SerializeObject(details);

            if(item != null)
            {
                var postTask = client.PutAsync("eventdetails/" + Id, new StringContent(item, Encoding.UTF8, "application/json"));
                postTask.Wait();
                var result = postTask.Result;
                return Json(new { success = result.IsSuccessStatusCode });
            }
            else
            {
                var postTask = client.PostAsync("eventdetails/", new StringContent(item, Encoding.UTF8, "application/json"));
                postTask.Wait();
                var result = postTask.Result;
                return Json(new { success = result.IsSuccessStatusCode });
            }
        }

        public async Task<JsonResult> Delete(string Id)
        {
            var deleteTask = client.DeleteAsync("eventdetails/" + Id);
            deleteTask.Wait();
            var result = deleteTask.Result;
            
            if(result.IsSuccessStatusCode)
            {
                return Json(new { success = result.IsSuccessStatusCode });
            }
            else
            {
                return Json(result.StatusCode);
            }
        }
    }
}
