using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using PractoEntity;
namespace PractoMVCWebApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult GetDoctors()
        {
            PractoModel DocList = new PractoModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55442/");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Home").Result;
            if (response.IsSuccessStatusCode)
            {
                var EmployeeDetails = response.Content.ReadAsAsync<IEnumerable<PractoModel>>().Result;
            }
            return View(DocList);
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}