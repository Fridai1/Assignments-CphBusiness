using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace BankClient
{
    public class Connection
    {
        private TcpClient clientSocket = new TcpClient("localhost", 6789);
        private StreamReader sr;
        private StreamWriter sw;

        public Connection()
        {
            Stream ns = clientSocket.GetStream();
             sr = new StreamReader(ns);
             sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing
        }

        public string GetFunds(string accountId, double amount)
        {
            if (!clientSocket.Connected)
            {
                TcpClient a = new TcpClient("localhost", 6789);
                clientSocket = a;
                // clientSocket.Client.Connect("localhost", 6789);
            }
           


            var message = $"{accountId} {amount}";
            sw.WriteLine(message);
            var serverAnswer =  sr.ReadLine();
            //ns.Close();
           // clientSocket.Client.Disconnect(true);
           // clientSocket.Close();
            if (serverAnswer != null)
            {
                return serverAnswer;
            }

            return "Unable to retrieve funds";


        }

        
    }
}