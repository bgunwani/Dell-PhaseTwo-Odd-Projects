using clientWebAPIApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace clientWebAPIApplication.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            List<User> users;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:35976");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/users").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<User>>(stringData);
            }
            return View(users);
        }

    }
}
