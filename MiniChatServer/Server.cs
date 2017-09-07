using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatServer
{
    public class Server
    {
        public Server()
        {

        }


        public void Start()
        {
            TcpListener serverL = new TcpListener(IPAddress.Loopback, 7070);
            serverL.Start();

            using (TcpClient socket = serverL.AcceptTcpClient())
            {
                using (NetworkStream ns = socket.GetStream())
                {
                    StreamReader sr = new StreamReader(ns);

                    StreamWriter sw = new StreamWriter(ns);

                    Console.WriteLine("Loop start");
                    while (true)
                    {
                        //Console.WriteLine("Socket Test");

                        //Modtager besked fra client
                        String line = sr.ReadLine();
                        Console.WriteLine("" + line);

                        if (!string.IsNullOrEmpty(line))
                        {
                            if (line.ToUpper() == "STOP")
                            {
                                break;
                            }
                        }

                        string myLine = Console.ReadLine();


                        //Sender input
                        sw.WriteLine(myLine);

                        


                        // tømme er flush
                        sw.Flush();
                    }
                }
                #region original code
                //using (StreamReader sr = new StreamReader(ns))
                //{
                //    using (StreamWriter sw = new StreamWriter(ns))
                //    {
                //        Console.WriteLine("Socket Test");
                //        String line = sr.ReadLine();
                //        Console.WriteLine("" + line);

                //        sw.WriteLine(line);


                //        // tømme er flush
                //        sw.Flush();
                //    }
                //}
                #endregion

            }

        }



    }
}

