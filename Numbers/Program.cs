using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string inputLen;
            string inputWid;

            Console.WriteLine("What is the length of the rectangle?");
            inputLen = Console.ReadLine();
            length = double.Parse(inputLen);

            Console.WriteLine("What is the width of the rectangle?");
            inputWid = Console.ReadLine();
            width = double.Parse(inputWid);

            area = length * width;

            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
