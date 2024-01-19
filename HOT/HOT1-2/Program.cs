using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double average = 0;

            // Input 3 numbers
            Write("Enter Number 1:\t");
            double num1 = double.Parse(Console.ReadLine());

            Write("Enter Number 2:\t");
            double num2 = double.Parse(Console.ReadLine());

            Write("Enter Number 3:\t");
            double num3 = double.Parse(Console.ReadLine());

            // Calculate the sum
            sum = num1 + num2 + num3;

            // Calculate the average
            average = sum / 3;

            WriteLine("The Sum Of 3 Numbers Is:\t" + sum.ToString());
            WriteLine("The Avg Of 3 Numbers Is:\t" + average.ToString("n2"));

            ReadLine();
        }
    }
}
