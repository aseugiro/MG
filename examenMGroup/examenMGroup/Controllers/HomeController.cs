using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace examenMGroup.Controllers
{
   
    public class HomeController : ApiController
    {
        private String key;
        private String share_secret;

        public HomeController() {
            key = "";
            share_secret = "";
        }

        [System.Web.Mvc.HttpPut]
        public void SetCredential(String key, String share_secret)
        {
            this.key = key;
            this.share_secret = share_secret;

        }


        [System.Web.Mvc.HttpPost]
        public String PostMessage(String msg, String tags)
        {
            return "post";
        }


        [System.Web.Mvc.HttpGet]
        public String GetMessage()
        {
            return "post";
        }


    }
}
