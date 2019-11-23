using System;

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
            for (int i = 1; i <= 100; i++)
            {
                int divBy3, divBy5;
                divBy3 = i % 3;
                divBy5 = i % 5;
                if (divBy3 == 0 && divBy5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (divBy3 == 0)
                    Console.WriteLine("Fizz");
                else if (divBy5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
