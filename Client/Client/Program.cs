﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.SetupClient("127.0.0.1", 9999);
            Console.WriteLine("Pressione qualquer tecla pra continuar...");
            Console.ReadLine();
        }
    }
}
