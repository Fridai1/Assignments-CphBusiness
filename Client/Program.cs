using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50052", ChannelCredentials.Insecure);
            var client = new StudentService.StudentServiceClient(channel);

            var reply = client.GetStudents(new StudentRequest {});
            string[] replyArray = reply.Info.Split('&');
            foreach (var student in replyArray)
            {
                int i = 1;
                Console.WriteLine($"Student #{i}: " + student );
            }
            


            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
