using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1_TestVisualClassDesigner
{
    public class AppControler : App
    {
        public new void Print()
        {
            Console.Write("Hello from AppControler from Print\n");
        }

        public void Print2()
        {
            Console.Write("Hello from AppControler from Print2\n");
        }
    }
}