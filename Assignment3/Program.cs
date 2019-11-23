using System;

namespace Assignment3
{
    class Program
    {/*1
      212
     32123
    4321234*/

        static void Main(string[] args)
        {
            string n="1";
            for (int i = 1; i < 10; i++)
            {
                int int1 = i + 1;
                string sout = int1.ToString() + n + int1.ToString();
                
                Console.WriteLine(n.PadLeft(int1+10));
                n = sout;

            }
        }
    }
}
