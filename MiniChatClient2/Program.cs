using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client 2 er strtet");
            Client2 client2 = new Client2();
            client2.Start();
        }
    }
}
