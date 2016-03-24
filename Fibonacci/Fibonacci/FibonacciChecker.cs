using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciChecker
    { 

        public void FibonacciSequence(int number)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int sum = 0;

            for (int index = 2; index < number; index++)
            {
                secondNumber = firstNumber;
                firstNumber = sum;
                sum = firstNumber + secondNumber;
                Console.WriteLine(sum);
            }
            Console.Read();
        }
    }
}