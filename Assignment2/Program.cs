using System;
using Assignment2;

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
            Swap sw = new Swap(x,y);
            Console.WriteLine("Before Swapping {X}= " + sw.x + " {Y}= " + sw.y);
            sw.swapNo();
            Console.WriteLine("Before Swapping {X}= " + sw.x + " {Y}= " + sw.y);

        }
            
       
          

       

    }
}
