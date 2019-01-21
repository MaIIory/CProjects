using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_LandscapeOrPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter the width and height of an image. 
            //Then tell if the image is landscape or portrait. 

            Console.WriteLine("Hello User, please give me width of the image:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, give me the height:");
            int height = int.Parse(Console.ReadLine());

            if (width > height)
                Console.WriteLine("You image is a landscape.");
            else
                Console.WriteLine("You image is a portrait.");
        }
    }
}
