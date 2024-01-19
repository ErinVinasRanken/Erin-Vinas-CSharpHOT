using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT1_1
{
    internal class Program
    {
        // Declare and initialize global variables
        static string first = "";
        static string last = "";

        static void Main(string[] args)
        {
            InputFirstName();
            InputLastName();
            PrintName();
        }

        // Input first name
        static void InputFirstName()
        {
            Write("\nPlease Input First Name:\t");
            first = ReadLine();
        }

        // Input last name
        static void InputLastName()
        {
            Write("\nPlease Input Last Name:\t");
            last = ReadLine();
        }

        static void PrintName()
        {
            string outputStr = $"First Name:\t\t{first}";
            outputStr += $"\nLast name:\t\t{last}";

            WriteLine($"Hello, {first} {last}");

            ReadLine();
        }
    }
}
