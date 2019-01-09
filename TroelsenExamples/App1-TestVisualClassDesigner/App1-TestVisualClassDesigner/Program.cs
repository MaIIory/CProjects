using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1_TestVisualClassDesigner
{
    public class App
    {
        static void Main(string[] args)
        {
            App item = new AppControler();

            item.Print();
            ((AppControler)item).Print();
            

            Console.ReadLine();
        }

        public void Print()
        {
            Console.Write("Hello World!\n");
        }
    }
}
