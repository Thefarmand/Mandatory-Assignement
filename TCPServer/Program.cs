using System;

namespace TCPServer
{
    class Program
    {
        private const int PORT = 7;
        static void Main(string[] args)
        {
            Server server = new Server(PORT);
            server.Start();
            Console.ReadLine();
        }
    }
}
