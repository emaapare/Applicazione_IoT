using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;

namespace Utilities
{
    public class Utility
    {

        static string[] content;
        public static string[] LoadConfig(string path)
        {
            FileInfo f = new FileInfo(path);
            try
            {
                string[] contents1 = File.ReadAllLines(path);
                return contents1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("starter file path in not correct");
                return new string[0]; 
            }
        }

        public static void ReadData(string[] contentt)
        {
            for (int i = 0; i < contentt.Length; i++)
            {
                switch(contentt[i])
                {
                    case "1":
                        {
                            EntryDevice ed = new EntryDevice();
                            ed.Print();
                            continue;
                        }

                    case "4":
                        {                           
                            Console.WriteLine("press 1 for device PRO1, press 2 for device PRO2: ");
                            int choose = Convert.ToInt32(Console.ReadLine());

                            switch (choose)
                            {
                                case 1:
                                    {
                                        Pro1 p1 = new Pro1();
                                        p1.Print();
                                        continue;
                                    }

                                case 2:
                                    {
                                        Pro2 p2 = new Pro2();
                                        p2.Print();
                                        continue;
                                    }
                            }
                            continue;
                        }

                    case "8":
                        {
                            Super s = new Super();
                            s.Print();
                            s.Send();
                            continue;
                        }

                    default:
                        {
                            Console.WriteLine("incompatible content");
                            continue;
                        }
                       
                }
            }
        }
    }
}
