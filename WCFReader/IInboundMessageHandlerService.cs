using System;
using System.ServiceModel;
using System.ServiceModel.MsmqIntegration;

namespace Interfaces
{
    [ServiceContract]
    public interface IInboundMessageHandlerService
    {
        [OperationContract(IsOneWay = true, Action = "*")]
        void ProcessIncomingMessage(MsmqMessage<String> incomingOrderMessage);
    }
}
