using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RestSharp;

namespace WebServiceClient
{
    [WebService(Namespace = "http://pucminas.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string SendMessage(string message)
        {
            var client = new RestClient("http://localhost/");

            var request = new RestRequest("wcf/NotificationService.svc/SendMessage", Method.POST);
            request.AddQueryParameter("message", message);

            IRestResponse response = client.Execute(request);
            //var content = response.Content;
            return "enviado para a fila: " + response.StatusCode;
        }
    }
}
