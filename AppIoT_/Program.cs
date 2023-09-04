using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Utilities;

namespace AppIoT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\emaap\Downloads\config.txt";
            string[] content = Utility.LoadConfig(path);

            Utility.ReadData(content);
        }
    }
}
