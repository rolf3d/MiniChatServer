﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server Start");
            Server serverl = new Server();
            serverl.Start();

            Console.ReadLine();
        }
    }
}
