using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_1
{
    //6 - July - 2017

    class Program
    {
        class Rectangle
        {
            public double length;
            public double height;

            public double GetArea()
            {
                return length * height;
            }

            public void Display()
            {
                Console.WriteLine("Length = {0} cm", length);
                Console.WriteLine("Height = {0} cm", height);
                Console.WriteLine("Area = {0} cm^2", GetArea());
            }
        }
        static void Main(string[] args)
        {
            //My first Program

            //Add program from here
            Console.WriteLine("My first program in C#! \n");

            //-------------------------------------------------------------------------

            Console.WriteLine("Rectangle.");
            Rectangle Rec = new Rectangle();
            Console.WriteLine("Masukkan Panjang:  ");
            Rec.length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Lebar: ");
            Rec.height = Convert.ToDouble(Console.ReadLine());
            Rec.GetArea();
            Rec.Display();
            Console.WriteLine("\n");

            Console.WriteLine("Data Type Size.");
            Console.WriteLine("Size of int = {0} byte(s)", sizeof(int));
            Console.WriteLine("\n");

            //-------------------------------------------------------------------------

            Console.WriteLine("Luas Lingkaran.");

            const double pi = 3.14159; //constant of pi
            double r;

            Console.WriteLine("Masukkan Jari-jari: \b");
            r = Convert.ToDouble(Console.ReadLine());
            double AreaCircle = pi * r * r;
            Console.WriteLine("Jari Jari = {0} cm, Luas = {1}", r, AreaCircle);

            //End of Adding Program
            Console.ReadKey();
        }
    }
}
