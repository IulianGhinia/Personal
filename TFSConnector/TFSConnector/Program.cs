﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFSConnector
{
    static class Program
    {
        /// <summary>
        /// Console construstor
        /// </summary>
        /// <param name="args">Arguments used during startup</param>
        static void Main(string[] args)
        {
            if (args.Count<string>() != 0)
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            Console.ReadLine();
        }
    }
}
