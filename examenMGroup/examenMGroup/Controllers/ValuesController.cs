using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace examenMGroup.Controllers
{
    public class ValuesController : ApiController
    {
        String key;
        String share_key;
        // GET api/values
        public HttpResponseMessage Get()
        {
            if (key != null)
            {

                return new HttpResponseMessage(HttpStatusCode.Forbidden);
            }
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put([FromBody]string key, [FromBody]string share_key)
        {
            this.key = key;
            this.share_key = share_key;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
