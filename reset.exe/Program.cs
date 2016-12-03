using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reset.exe {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This Application Was Created To Reset Your SMOL Webserver Installation To The\nFacrory Defaults For Easy Removal Or Because Of Corruption Of Files");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Exit Application");
            Console.WriteLine("2. Complete Reomoval Of All Files Exept SMOL.exe And Dependant Dlls");
            Console.WriteLine("3. Reset www Folder");
            Console.WriteLine("4. Reset Config");
            Console.ForegroundColor = ConsoleColor.Gray;
            string type = Console.ReadLine();
            int typeint;
            try {
                typeint = Int32.Parse(type);
            } catch {
                Console.WriteLine("Choose A Number");
                typeint = 0;
                Main(args);
            }
            switch (typeint) {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    File.Delete("SMOL_Config.json");
                    Directory.Delete("www\\", true);
                    break;
                case 3:
                    Directory.Delete("www\\", true);
                    break;
                case 4:
                    File.Delete("SMOL_Config.json");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Completed, Press Enter To Exit...");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        public static void clearDir() {

        }
    }
}
