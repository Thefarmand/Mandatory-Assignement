using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MandatoryAssignment;

namespace TCPServer
{
    public class Server
    {
        //Deklarerer en port
        private readonly int Port1;

        //Konstruerer et objekt Server
        public Server(int Port1)
        {
            this.Port1 = Port1;
        }

        //Start metode
        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, Port1);
            serverListener.Start();
            while (true)
            {
                var client = serverListener.AcceptTcpClient();
                Task.Run(() => DoClient(client));
            }
        }

        private void DoClient(TcpClient socket1)
        {
            Console.WriteLine("Start of handling of client");
            while (socket1.Connected)
            {
                //Variabel til new stream
                var newStream = socket1.GetStream();
                //Variabel til streamreader
                var sr = new StreamReader(newStream);
                //Variabel til streamwriter
                var sw = new StreamWriter(newStream);
                //Tømmer bufferen efter hver "write operation"
                sw.AutoFlush = true;
                string[] incStrings;
                incStrings = sr.ReadLine().Split(' ');
                string ConvertionOption = incStrings[0].ToUpper();
                if (ConvertionOption == "TOGRAM")
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = Converter.ToGram(weight);
                    sw.WriteLine(result);
                }
                else
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = Converter.ToOunce(weight);
                    sw.WriteLine(result);
                }
            }
        }
    }
}
