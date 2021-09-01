using System;
using System.Collections.Generic;
using System.Text;

namespace Kvadrat_OOP
{
     public class Square
    {
        // Properties

        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                side = 5;
            }
        }

        // Constructor
        // Initialize your attribute
        public  Square() 
        { 

        }
        
        public Square(int a)
        {
            this.side = a;
        }

        // Methods
        public int Omkreds()
        {
            int a = 4 *sSide;
            return a;
        }

        public double Arealet()
        {
            double a = Math.Pow(side, 2);
            return a;
        }


    }
}
