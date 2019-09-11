using System;
using System.IO;
using System.Net.Sockets;

namespace BankClient
{
    public class ThrowAwayClient
    {
         TcpClient clientSocket = new TcpClient("127.0.0.1", 6789);

        void start()
        {
            NetworkStream ns = clientSocket.GetStream();
            var sr = new StreamReader(ns);
            var sw = new StreamWriter(ns);
            sw.AutoFlush = true;


            while (true)

            {
                string messageToServer = Console.ReadLine();
                sw.WriteLine(messageToServer);

                string messageFromServer = sr.ReadLine();
                Console.WriteLine("Server: " + messageFromServer);
            }


            clientSocket.Close();



        }
    }
}