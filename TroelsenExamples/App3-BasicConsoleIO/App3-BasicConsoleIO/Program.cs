using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace App3_BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            FormatNumericalData();
            DisplayMessage();
            Console.ReadLine();
        }

        static void GetUserData()
        {
            //get user name and age
            Console.WriteLine("Type your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Type your age: ");
            string userAge = Console.ReadLine();

            //change echo color
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //print user data
            Console.WriteLine("Hello {0}, your age is {1}.", userName,userAge);

            //restore echo color
            Console.ForegroundColor = prevColor;
        }

        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c  format: {0:c}",99999);
            Console.WriteLine("d9 format: {0:d9}",99999);
            Console.WriteLine("f3 format: {0:f3}",99999);
            Console.WriteLine("n  format: {0:n}",99999);

            Console.WriteLine("E  format: {0:E}",99999);
            Console.WriteLine("e  format: {0:e}",99999);
            Console.WriteLine("X  format: {0:X}",99999);
            Console.WriteLine("x  format: {0:x}",99999);
        }

        static void DisplayMessage()
        {
            string userMessage = string.Format("99999 number in hex is {0:x}", 99999);

            //display message box
            //PresentationFramework assembly needs to be referenced
            MessageBox.Show(userMessage);
        }
    }
}
