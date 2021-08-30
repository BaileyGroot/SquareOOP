﻿using System;

namespace Kvadrat_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of the class: Square

            Square square = new Square(3);
            Square square1 = new Square(6);
            Square square2 = new Square(9);

            // Printing perimeter out

            Console.WriteLine(square.Omkreds());
            Console.WriteLine(square1.Omkreds());
            Console.WriteLine(square.Arealet());
            Console.WriteLine(square1.Arealet());
            Console.WriteLine(square2.MyProperty);

            // Preventing the program from closing down.
            Console.ReadKey();

        }
    }
}
