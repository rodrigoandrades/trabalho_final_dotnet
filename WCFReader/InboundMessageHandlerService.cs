using System;
using System.ServiceModel;
using System.ServiceModel.MsmqIntegration;
using Interfaces;
using Shared.Contracts;

namespace WCFReader
{
    //SINGLE -> INSTANCIA UNICA e Sigle-Thread
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single, ReleaseServiceInstanceOnTransactionComplete = false)]
    public class NotificationInboundMessageHandlerService : IInboundMessageHandlerService
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void ProcessIncomingMessage(MsmqMessage<Notification> incomingMessage)
        {
            //var notification = incomingMessage.Body;

            Console.WriteLine("------------------------------------ mensagem recebida ---------------------------------------");
            //Console.WriteLine(notification.Mensagem);
            //Console.WriteLine();
        }
    }
}
