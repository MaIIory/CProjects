using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that picks a random number between 1 and 10.
             * Give the user 4 chances to guess the number. If the user guesses the number,
             * display “You won"; otherwise, display “You lost". */

            int nbOfGuesses = 4;
            var rand = new Random();

            int secretNumber = rand.Next(1,10);
            Console.WriteLine("Secret Number is {0}",secretNumber);

            Console.WriteLine("Guess secret number, you have {0} chances:",nbOfGuesses);
            for(int i = 0; i < nbOfGuesses; i++ )
            {
                if(secretNumber == Int32.Parse(Console.ReadLine()))
                {
                    Console.WriteLine("You guessed!");
                    return;
                }
                else
                {
                    Console.WriteLine("You have not guessed :(");
                }
            }
            Console.WriteLine("You have lost!");
        }
    }
}
