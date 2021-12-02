using System;

namespace ConsoleClassWork_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();
        }

        static void Task1() 
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var result = (5 * a) + (b * b) / (b - a);

            Console.WriteLine(result);
        }

        static void Task2()
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            string tmp = A;
            A = B;
            B = tmp;

            Console.WriteLine("A = " + A + " B = " + B);
        }

        static void Task3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

             //В чем разница?
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            var divisionResult = a / b;
            int remainder = a % b;

            Console.WriteLine("divisionResult = " + divisionResult + " remainder = " + remainder);
        }

        static void Task4()
        {
            // a * X + b = c

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            /*
            float a = int.Parse(Console.ReadLine());
            float b = int.Parse(Console.ReadLine());
            float c = int.Parse(Console.ReadLine());
            */
            double X = (c - b) / a;

            Console.WriteLine("X = " + X);
        }

        static void Task5()
        {
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            

        }
    }

}
