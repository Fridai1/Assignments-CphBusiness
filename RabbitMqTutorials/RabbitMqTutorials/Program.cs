using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "Campaign", type: ExchangeType.Direct);
                string campaign ="";
                while (campaign != "break")
                {
                    Console.WriteLine("what campaign to send? Winter, Summer or Autumn");
                    campaign = Console.ReadLine().ToLower();
                    string message = GetAdvertisement(campaign);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "Campaign",
                        routingKey: $"{campaign}",
                        basicProperties: null,
                        body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }

            
        }

        private static string GetAdvertisement(string campaign)
        {
            
            switch (campaign)
            {
                case "winter":
                {
                    return "hey its cold, go somewhere warm";
                }
                case "summer":
                {
                    return "Tired of sweat in the crack? me too, lets go to antarctica";
                }
                case "autumn":
                {
                    return "this is perfect, why not rent the neighbors house?";
                }
            }

            return "Dreams come true this autumn";
        }
    }
}


