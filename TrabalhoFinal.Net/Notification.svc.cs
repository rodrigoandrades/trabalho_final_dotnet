using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Transactions;

namespace TrabalhoFinal.Net
{
    public class Notification : INotification
    {
        public void SendMessage(string message)
        {
            using (var queue = new MessageQueue(ConfigurationManager.AppSettings["MessageQueuePath"]))
            {
                // Criando uma msg
                var msg = new System.Messaging.Message { Body = message };

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
