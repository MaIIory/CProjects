using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App2_SimpleCSharpApp, Hello {0}!",Environment.UserName);

            //args table contains input arguments from user
            Console.WriteLine("Length of args table: {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("args[{0}]: {1}", i, args[i]);

            //Here is alternative way to read arguments
            string[] theArgs = Environment.GetCommandLineArgs();
            Console.WriteLine("Length of theArgs table: {0}", theArgs.Length);
            foreach (string arg in theArgs)
                Console.WriteLine("theArgs: {0}", arg);

            //Print system details
            ShowSystemDetails();

            Console.ReadLine();
        }

        static void ShowSystemDetails()
        {
            Console.WriteLine("OS Version: {0}", Environment.OSVersion);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.Write("Installed disks: ");

            foreach (string disk in Environment.GetLogicalDrives())
                Console.Write("{0} ", disk);
            Console.Write("\n");
        }
    }
}
