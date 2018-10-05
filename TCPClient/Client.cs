using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    class Client
    {
        private const int PORT = 7;

        public void Start()
        {
            var client = new TcpClient("localhost", PORT);

            while (true)
            {
                var newStream = client.GetStream();
                var sr = new StreamReader(newStream);
                var sw = new StreamWriter(newStream);
                sw.AutoFlush = true;

                sw.WriteLine(Console.ReadLine());
                Console.WriteLine(sr.ReadLine());

            }

        }
    }
}
