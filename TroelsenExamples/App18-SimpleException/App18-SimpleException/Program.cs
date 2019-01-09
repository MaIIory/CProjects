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

            //TRY and CATCH syntax
            try
            {
                //Uncomment this line to trigger second catch block 
                //myCar.Accelerate(0); 

                while (!myCar.isDead)
                    myCar.Accelerate(10);
            }
            catch(CarExplodedException e)
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
            catch(Exception e) 
            //More general exceptions should be put after more specific ones, as the first match is called 
            //otherwise compilation error will be generated
            {
                Console.WriteLine("Exception message: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Shutting down engine...");
            }

            //CATCH without argument
            try
            {
                //some logic
            }
            catch
            {
                //catch all exceptions, and handle without Exception object
                Console.WriteLine("Somethig bad has just happened!");
            }

            //THROW in CATCH block
            try
            {
                //some logic
            }
            catch
            {
                throw; //The instruction throws excxeption to next caller
            }

            Console.ReadLine();
        }
    }
}
