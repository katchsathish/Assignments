using System;
using Assignment1;

namespace Assignment1
{
    class Program
    {/*Assignment 1:
        Write a program that prints the numbers from 1 to 100. 
        But for multiples of three print "Fizz" instead of the number and for the
        multiples of five print "Buzz".
        For numbers which are multiples of both
        three and five print "FizzBuzz".*/
        static void Main(string[] args)
        {
            divClass dv = new divClass();
            for (int i = 1; i <= 100; i++)
            {
                if (dv.divby(i,3) == 0 && dv.divby(i,5) == 0)
                    Console.WriteLine("FizzBuzz");
                else if (dv.divby(i, 3) == 0)
                    Console.WriteLine("Fizz");
                else if (dv.divby(i, 5) == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

            }


        }
    }
}
