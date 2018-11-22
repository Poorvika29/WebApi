using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
//using System.Web.Mvc;
using PractoEntity;

namespace PractoWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            List<PractoModel> DocList = new List<PractoModel>() {
                    new PractoModel() { Name = "John"} ,
                    new PractoModel() { Name = "Steve"} ,
                    new PractoModel() { Name = "Bill"} ,
                    new PractoModel() { Name = "Bill"} ,
                    new PractoModel() { Name = "Ram" } ,
                    new PractoModel() { Name = "Ron" }
                };

           // return DocList;
            return View(DocList);
        }

        public ActionResult Get1()
        {
            PractoModel name = new PractoModel();
            name.Name = "API";
            ViewBag.CName = name.Name;
            return View(ViewBag.CName);
        }


        [System.Web.Http.HttpGet]
        public List<PractoModel> Get()
        {
            List<PractoModel> DocList = new List<PractoModel>() {
                    new PractoModel() { Name = "John"} ,
                    new PractoModel() { Name = "Steve"} ,
                    new PractoModel() { Name = "Bill"} ,
                    new PractoModel() { Name = "Bill"} ,
                    new PractoModel() { Name = "Ram" } ,
                    new PractoModel() { Name = "Ron" }
                };

            return DocList;
        }
    }
}
