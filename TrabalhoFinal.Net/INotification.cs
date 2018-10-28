﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TrabalhoFinal.Net
{
    [ServiceContract]
    public interface INotification
    {

        [OperationContract]
        void SendMessage(string message);
    }
}
