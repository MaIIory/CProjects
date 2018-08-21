using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ViewFactory
{
    class ClientView : Viewable
    {
        public void ShowWelcomeScreen()
        {
            Console.WriteLine("Hi Dear Client!");
        }
    }
}
