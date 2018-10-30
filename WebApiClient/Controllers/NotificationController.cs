using System.Web.Http;
using RestSharp;

namespace WebApiClient.Controllers
{
    public class NotificationController : ApiController
    {
        // POST: api/Notification
        [HttpPost]
        public void Post(string message)
        {
            var client = new RestClient("http://localhost/");

            var request = new RestRequest("wcf/NotificationService.svc/SendMessage", Method.POST);
            request.AddQueryParameter("message", message);

            IRestResponse response = client.Execute(request);
            //var content = response.Content;
        }
    }
}
