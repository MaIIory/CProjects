using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App23_AdvancedDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zoltek", 120, 10);

            //myCar.RegisterWithCarEngine(OnCarEngineEvent);

            //Multicasting - more than one event handler is assigned
            myCar.RegisterWithCarEngine(new CarEngineHandler(OnCarEngineEvent));
            myCar.RegisterWithCarEngine(new CarEngineHandler(OnCarEngineEventInUpper));

            //METHOD GROUP CONVERSION - you may pass only method name instead new instanse of delegate class as below:
            CarEngineHandler myCarDelegate = new CarEngineHandler(OnCarEngineEvent);
            // ==
            CarEngineHandler myCarDelegate2 = OnCarEngineEvent;

            for (int i = 0; i < 10; i++)
                myCar.Accelerate(20);

            Console.ReadLine();
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("Message from Car Object: {0}",msg);
        }

        public static void OnCarEngineEventInUpper(string msg)
        {
            Console.WriteLine("Message from Car Object: {0}", msg.ToUpper().ToString());
        }
    }
}
