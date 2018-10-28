using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.MsmqIntegration;
using System.Text;
using Interfaces;

namespace WCFReader
{
    //SINGLE -> INSTANCIA UNICA e Sigle-Thread
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single, ReleaseServiceInstanceOnTransactionComplete = false)]
    public class NotificationInboundMessageHandlerService : IInboundMessageHandlerService
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void ProcessIncomingMessage(MsmqMessage<String> incomingOrderMessage)
        {
            var orderRequest = incomingOrderMessage.Body;

            Console.WriteLine("------------------------------------ mensagem recebida ---------------------------------------");
            Console.WriteLine(orderRequest);
            Console.WriteLine();
        }
    }
}
