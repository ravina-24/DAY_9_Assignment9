using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_9_Assignment9
{
    class PrimeNumber
    {

        public  void checkPrimeNumber()
        {

            Console.WriteLine("Checking prime number");
            int Number;
            Console.WriteLine("Enter number = ");
            Number = Convert.ToInt32(Console.ReadLine());

            if (Number%2 == 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine( true);
            }


            Console.ReadLine();
        }
    }
}
