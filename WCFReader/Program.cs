using System;
using System.ServiceModel;

namespace WCFReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(NotificationInboundMessageHandlerService)))
            {
                host.Faulted += Faulted;
                host.Open();

                Console.WriteLine("Serviço iniciado ...");

                //Se apertar qualquer tecla vai sair do console
                Console.ReadLine();

                if (host != null)
                {
                    if (host.State == CommunicationState.Faulted)
                    {
                        host.Abort();
                    }
                    host.Close();
                }
            }
        }

        static void Faulted(object sender, EventArgs e)
        {
            Console.WriteLine("Problema no WCF");
        }
    }
}
