using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18_SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            //Following part of the code, surely will throw an exception
            //so the exception object has to be handled 

            try
            {
                while (!myCar.isDead)
                    myCar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("*** EXCEPTION OCCURED ***");
                Console.WriteLine("Exception message: {0}",e.Message);
                Console.WriteLine("Exception stack trace: {0}",e.StackTrace);
                Console.WriteLine("Ex source: {0}", e.Source);
                Console.WriteLine("Ex TargetSite: {0}",e.TargetSite);
                Console.WriteLine("Ex data number: {0}",e.Data.Keys.Count);

                foreach(System.Collections.DictionaryEntry de in e.Data)
                    Console.WriteLine("de key: {0}, de value: {1}", de.Key, de.Value);
                
                
            }

            Console.ReadLine();
        }
    }
}
