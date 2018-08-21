using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ViewFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new Client();

            Viewable view = user.viewFactory.CreateView();
            view.ShowWelcomeScreen();

            Console.ReadLine();
        }
    }
}
