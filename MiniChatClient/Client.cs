using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatClient
{
    public class Client
    {
        public void Start()
        {
            using (TcpClient client = new TcpClient("localhost", 7070))

            using (NetworkStream ns = client.GetStream())
            {
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);

                while (true)
                {
                    String sendStr = Console.ReadLine();
                    sw.WriteLine(sendStr);
                    sw.Flush();

                    String incomingStr = sr.ReadLine();
                    Console.WriteLine("Ekko Modtaget: " + incomingStr);


                }
            }

        }
    }
}
