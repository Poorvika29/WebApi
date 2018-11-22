using PractoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PractoWebApi.Controllers
{
    public class PractoController : ApiController
    {
        List<PractoModel> DocList = new List<PractoModel>();
        public PractoController()
        {
            GetAllDoctors();
        }

        private void GetAllDoctors()
        {
            DocList = new List<PractoModel>() {
                    new PractoModel() { Name = "John"} ,
                    new PractoModel() { Name = "Steve"} ,
                    new PractoModel() { Name = "Bill"} ,
                    new PractoModel() { Name = "Bill"} ,
                    new PractoModel() { Name = "Ram" } ,
                    new PractoModel() { Name = "Ron" }
            };
        }
        public IEnumerable<PractoModel> Get()
        {
            return DocList;
        }
    }
}
