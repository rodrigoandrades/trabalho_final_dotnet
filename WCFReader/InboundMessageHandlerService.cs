using System;
using System.ServiceModel;
using System.ServiceModel.MsmqIntegration;
using Interfaces;
using Shared.Contracts;

namespace WCFReader
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single, ReleaseServiceInstanceOnTransactionComplete = false)]
    public class NotificationInboundMessageHandlerService : IInboundMessageHandlerService
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void ProcessIncomingMessage(MsmqMessage<NotificationMessage> incomingMessage)
        {
            NotificationMessage notificationMessage = incomingMessage.Body;
            Console.WriteLine("------------------------------------ mensagem recebida ---------------------------------------");
            Console.WriteLine(notificationMessage.Data);
            Console.WriteLine(notificationMessage.Mensagem);
            Console.WriteLine();

            var notification = new Notification
            {
                data = notificationMessage.Data,
                mensagem = notificationMessage.Mensagem
            };

            using (var db = new DbModel())
            {
                db.Notifications.Add(notification);
                db.SaveChanges();
            }
            Console.WriteLine("mensagem inserida no banco de dados");
        }
    }
}
