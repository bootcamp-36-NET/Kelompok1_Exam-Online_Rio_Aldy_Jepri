using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExamOnlineClient.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnlineClient.Controllers
{
    public class AccountController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://winarto-001-site1.dtempurl.com/api/")
        };
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }

        public IActionResult Login(LoginVM loginVM)
        {
            string stringData = JsonConvert.SerializeObject(loginVM);
            var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

            var resTask = client.PostAsync("auths/login", contentData);

            var result = resTask.Result;
            var responseData = result.Content.ReadAsStringAsync().Result;

            if (result.IsSuccessStatusCode)
            {
                //var token = new JwtSecurityToken(jwtEncodedString: responseData);
                var authToken = "Bearer " + responseData;
                HttpContext.Session.SetString("JWToken", authToken);
                var handler = new JwtSecurityTokenHandler();
                var tokens = handler.ReadJwtToken(responseData);
                var jwtPayloadSer = JsonConvert.SerializeObject(tokens.Payload.ToDictionary(x => x.Key, x => x.Value));
                var jwtPayloadDes = JsonConvert.DeserializeObject(jwtPayloadSer).ToString();
                var account = JsonConvert.DeserializeObject<AccountVM>(jwtPayloadSer);
                //var isVerified = token.Claims.First(c => c.Type == "IsVerified").Value;

                HttpContext.Session.SetString("id", account.Id);
                HttpContext.Session.SetString("email", account.Name);
                HttpContext.Session.SetString("role", account.RoleName);
                HttpContext.Session.SetString("name", account.Name);
                //HttpContext.Session.SetString("verified", token.Claims.First(c => c.Type == "IsVerified").Value);
                //HttpContext.Session.SetString("JWToken", authToken);

                return Json((result, responseData), new Newtonsoft.Json.JsonSerializerSettings());
            }
            return Json((result, responseData), new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}