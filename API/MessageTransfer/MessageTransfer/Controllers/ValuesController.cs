using MessageTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessageTransfer.Controllers
{
    public class ValuesController : ApiController
    {
        MessageContext ctx = new MessageContext();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //[HttpPost]
        //[Route("api/Savemessage")]
        //public string Savemessage(tblMessage msg)
        //{
        //    ctx.tblMessages.Add(msg);
        //    ctx.SaveChanges();
        //    return "Save Successfully";
        //}
    }
}
