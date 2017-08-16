using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace TCP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TcpClient client = new TcpClient();
            Console.WriteLine("Connecting...");

            client.Connect("localhost", 20000);

            Console.Clear();
            Console.WriteLine("Connected");

            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("hello server");
            Console.WriteLine(reader.ReadLine());

            Console.ReadLine();

            client.Close();

        }
    }
}
