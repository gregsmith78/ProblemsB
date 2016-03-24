using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciChecker check = new FibonacciChecker();
            check.FibonacciSequence(30);


            /*  int firstNumber = 5;
              int secondNumber = 0;
              int sum = 0;
              for(int index = 0; index < 15; index++)
              {
                  secondNumber = firstNumber;
                  firstNumber = sum;
                  sum = firstNumber + secondNumber;
                  Console.WriteLine(sum);
              }
              Console.Read();

          }
      } */
        }
    }
}
