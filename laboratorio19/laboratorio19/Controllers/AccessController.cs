using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using laboratorio19.Models.WS;

namespace laboratorio19.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply HelloWorld()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.message = "Mi Hello World en API";

            return oR;
        }

        // Laboratorio 19-2
        [HttpGet]
        public IEnumerable<Reply> GetAll()
        {
            return new List<Reply>
            {
                new Reply { result = 1, message = "value1" },
                new Reply { result = 1, message = "value2" }
            };
        }

        // Laboratorio 19-3
        [HttpGet]
        public Reply Get(int id)
        {
            if (id == 2)
            {
                return new Reply { result = 1, message = "value2" };
            }

            return new Reply { result = 0, message = "Not found" };
        }
    }
}
