using System;
using System.Configuration;
using System.Messaging;
using System.Transactions;
using Shared.Contracts;

namespace WCFRest
{
    public class NotificationService : INotificationService
    {
        public void SendMessage(string message)
        {
            using (var queue = new MessageQueue(ConfigurationManager.AppSettings["MessageQueuePath"]))
            {
                // Criando uma msg
                var notification = new Notification { Mensagem = message, Data = DateTime.Now };

                Message msg = new Message();
                msg.Body = notification;

                // Criando uma transação
                using (var ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    queue.Send(msg, MessageQueueTransactionType.Automatic);
                    ts.Complete();
                }
            }
        }
    }
}
