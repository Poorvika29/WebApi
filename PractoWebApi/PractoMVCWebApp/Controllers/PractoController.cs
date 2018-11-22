using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PractoEntity;

namespace PractoMVCWebApp.Controllers
{
    public class PractoController : Controller
    {
        // GET: Practo
        public ActionResult Index()
        {
            var Doctors = GetDoctors();
            return View(Doctors);
        }

        private List<PractoModel> GetDoctors()
        {
            var DoctorsList = new List<PractoModel>();
            try
            {
                var Client = new HttpClient();
                var getDataTask = Client.GetAsync("http://localhost:55442/api/Practo").
                    ContinueWith(response=>
                    {
                        var result = response.Result;
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var readresult = result.Content.ReadAsAsync<List<PractoModel>>();
                            readresult.Wait();
                            DoctorsList = readresult.Result;
                        }
                    }
                );
                getDataTask.Wait();
                return DoctorsList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}