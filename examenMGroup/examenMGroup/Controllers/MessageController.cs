using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace examenMGroup.Controllers
{
    public class MessageController : ApiController
    {

      

        // GET api/message/5
        public HttpResponseMessage Get(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Get(String tag)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        // POST api/values
        public HttpResponseMessage Post([FromBody] String msg,[FromBody]string tag)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

       

        


    }
}
