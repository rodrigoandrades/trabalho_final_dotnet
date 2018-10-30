using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRest
{
    [ServiceContract]
    public interface INotificationService
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "SendMessage?message={message}", Method = "POST")]
        void SendMessage(string message);
    }
}
