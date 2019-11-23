using System;

namespace Assignment2
{
    class Program
    {
        /*Assignment 2:
        Swap 2 nos with out using a third variable or any pre defined function
        Swap(int x,int y)*/

        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Before Swapping {X}= " + x +" {Y}= "+y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After Swapping {X}= " + x + " {Y}= " + y);
        }
            
       
          

       

    }
}
