using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //1.Find maximum number from given 3 numbers.

        static void Main(string[] args)
        {
            int num1, num2, num3;
            // set the value of the three numbers
            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest");

                }
                else
                {
                    Console.Write("Number three is the largest");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest");
            else
                Console.Write("Number three is the largest");
        }
    }
}
