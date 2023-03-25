using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebMVCKsp.Models;

namespace WebMVCKsp.Controllers
{
    public class EmployeeController : Controller
    {
        Uri baseUri = new Uri("https://localhost:7172/");
        private readonly HttpClient httpClient;

        public EmployeeController()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = baseUri;
        
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<EmployeeViewModel> ListEmployees = new List<EmployeeViewModel>();
            HttpResponseMessage httpResponse = httpClient.GetAsync(httpClient.BaseAddress + "employee/employeelist").Result;
            if(httpResponse.IsSuccessStatusCode)
            {
                string data = httpResponse.Content.ReadAsStringAsync().Result;
                ListEmployees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(data);
            }
            return View(ListEmployees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            try
            {
                model.Photo = "";
                string data = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponse = httpClient.PostAsync(httpClient.BaseAddress + "employee/addemployee", stringContent).Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Empleado registrado correctamente";
                    RedirectToAction("Employee/Index");
                }
            }
            catch (Exception ex) 
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();
        }
    }
}
