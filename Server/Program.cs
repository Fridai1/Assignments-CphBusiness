using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace Server
{
    class ServerImpl : StudentService.StudentServiceBase
    {
        Reader reader = new Reader();
        public override Task<StudentReply> GetStudents(StudentRequest request, ServerCallContext context)
        {
            string output = reader.GetStudents();
            return Task.FromResult(new StudentReply {Info = output});
        }

       
    }
    class Program
    {
        const int Port = 50052;
        static void Main(string[] args)
        {
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { StudentService.BindService(new ServerImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Greeter server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
