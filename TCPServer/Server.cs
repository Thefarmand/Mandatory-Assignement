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

                //try
                //{
                //    incStrings = sr.ReadLine().Split(' ');
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine("Lost connection to client.");
                //    return;
                //}
                incStrings = sr.ReadLine().Split(" ");
                //Alt det indtastede bliver til store bogstaver
                var convertOption = incStrings[0].ToUpper();
                //Tjek indtastet tekst
                if (convertOption == "TOGRAM" || convertOption == "TOOUNCES")
                {
                    //Hvis der er mindre eller mere end to input giv fejl
                    if (incStrings.Length != 2)
                    {
                        sw.Write($"No or too many values given\n");
                    }
                    //Hvis ingen fejl find værdien af det indtastede
                    else if (double.TryParse(incStrings[1], out double inputValue))
                    {
                        sw.Write(convertOption == "TOGRAM"
                            ? $"{Converter.ToGram(inputValue)}\n"
                            : $"{Converter.ToOunce(inputValue)}\n");
                    }

                    else
                    {
                        //Giv fejlmeddelelse ved forkert indtastet værdi
                        sw.Write($"Incorrect value - {incStrings[1]}\n");
                    }
                }
                else
                {
                    //Forkert indtastet option. fx Togrammy - giv fejlmeddelelse
                    sw.Write($"Incorrect option - {incStrings[0]}\n");
                }
            }
        }
    }
}
