using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_9_Assignment9
{
    class Factorial
    {
        public void findFactorial()
        {
            int num;
            Console.WriteLine("Enter number ");
            num = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i=1;i<=num;i++)
            {
                factorial = factorial * i;
              
            }

            Console.WriteLine("factorial = " + factorial);

            Console.ReadLine();
        }
    }
}
