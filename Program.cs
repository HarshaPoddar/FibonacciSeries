using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter the term you need to find in the Fibonacci Series: ");
            int Term = Convert.ToInt32(Console.ReadLine());
            int Answer = Fibonacci(Term);
            Console.WriteLine("The {0} Term of the Fibonacci is: " + Answer , Term);
            Console.ReadLine();
        }
         static int Fibonacci(int number)
        {
            int sum = 0;
            if (number <= 1)
                return 1;
            else
            {
                sum = (Fibonacci(number - 2) + Fibonacci(number - 1));
               return sum;
                    }
             
        }
    }
}
