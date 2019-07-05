using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace pruebaMG
{
    /// <summary>
    /// Descripción breve de WebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServices : System.Web.Services.WebService
    {
        private String key;
        private String share_key;

        [WebMethod]
        public string credential(String key,String share_key)
        {
            return "return 203";
        }

        [WebMethod]
        public string message()
        {
            return "Hola a todos";
        }
    }
}
