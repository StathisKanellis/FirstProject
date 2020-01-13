using System;

namespace Homework1
{
    class Program
    {
        static int inputValue(int a)
        {
            Console.Write("Please insert a number: ");
            a = Convert.ToInt16(Console.ReadLine());
            return a;
        }

        static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        static int mul(int a, int b, int c)
        {
            return a * b * c;
        }

        static double aver(int a, int b, int c)
        {

            return (double)(a + b + c) / 3;
        }

        static void outputValue(string a, double b)
        {
            Console.WriteLine($"The {a} of your numbers is: {b}");
            return;
        }


        static void Main(string[] args)
        {

            int x = inputValue(0);
            int y = inputValue(0);
            int z = inputValue(0);


            outputValue("addition", add(x, y, z));
            outputValue("multiplication", mul(x, y, z));
            outputValue("average", Math.Round(aver(x, y, z), 2));
           

            Console.ReadKey();
        }
    }
}
