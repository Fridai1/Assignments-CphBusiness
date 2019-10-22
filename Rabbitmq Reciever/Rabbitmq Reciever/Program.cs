using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;



namespace Rabbitmq_Reciever
{
    
    class Program
    {
        public static event Action RaiseChoice;
        static void Main(string[] args)
        {
            List<string> interestList = new List<string>();

            var factory = new ConnectionFactory() {HostName = "localhost"};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                RaiseChoice += Choice;
                channel.ExchangeDeclare(exchange: "Campaign", type: ExchangeType.Direct);
                Console.WriteLine("Here at your very own flight ticket place");
                Console.WriteLine("which campaign are you interested in? Winter, Summer or Autumn?");
                string interest = Console.ReadLine();
               
                interestList.Add(interest);
                interestList.Add("");
                var queueName = channel.QueueDeclare().QueueName;

                foreach (var v in interestList)
                {
                    channel.QueueBind(queue: queueName,
                        exchange: "Campaign",
                        routingKey: $"{v}");
                }
                

                Console.WriteLine(" [*] Waiting for logs.");
                while (true)
                {
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] {0}", message);
                        //new Task(Choice).Start();
                        //RaiseChoice?.Invoke();
                        Choice();

                    };
                    channel.BasicConsume(queue: queueName,
                        autoAck: true,
                        consumer: consumer);
                    
                }
            }

        }

        private static void Choice()
        {
            Console.WriteLine("Would you like to confirm this booking? Confirm[c] or Pass[p]");
            
            string answer = Console.ReadLine();
            if (answer == "c")
            {
                Console.WriteLine("Booking Confirmed");
            }
            else if (answer == "p")
            {
                Console.WriteLine("Booking has been passed");
            }
            Console.ReadKey();
        }
    }
}

