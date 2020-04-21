using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class calc
    {
          private double total;
          
          private  double tip;
          const double tax = 0.07;

        public int numPastry = 0;

        //constructor 

        public calc (double ctotal,  double ctip)
        {
            total = ctotal;
            tip = ctip;
        }

        //if else

      

        public double math()
        {
            total = total + (total * tax);
            total = total + tip;

            return total;
          

        }
    }
}
