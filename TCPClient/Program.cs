using System;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose TOGRAM or TOOUNCES");
            Client client = new Client();
            client.Start();
            Console.ReadKey();
        }
    }
}
