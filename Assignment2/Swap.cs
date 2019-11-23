using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public class Swap
    {
        public int x, y;
        public void swapNo()
        {

            x = x + y;
            y = x - y;
            x = x - y;
                    
        }
        public Swap(int x1,int y1)
        {
            x = x1;
            y = y1;
        }
    }
}
