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
        [WebGet(UriTemplate = "SendMessage?message={message}")]
        void SendMessage(string message);
    }
}
