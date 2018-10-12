using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TrabalhoFinal.Net
{
    public class Notification : INotification
    {
        public string GetMessage(string message)
        {
            return string.Format("You entered: {0}", message);
        }
    }
}
