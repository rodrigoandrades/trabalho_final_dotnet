using Shared.Contracts;
using System.ServiceModel;
using System.ServiceModel.MsmqIntegration;

namespace Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof(NotificationMessage))]
    public interface IInboundMessageHandlerService
    {
        [OperationContract(IsOneWay = true, Action = "*")]
        void ProcessIncomingMessage(MsmqMessage<NotificationMessage> incomingMessage);
    }
}
