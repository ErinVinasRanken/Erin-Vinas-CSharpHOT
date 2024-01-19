using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HOT1_3
{
    internal class Program
    {
        // Declare and initialize program constants
        const decimal SHIRTPRICE = 14.99M;
        const decimal SALESTAX = 0.08m;

        // Declare and initialize global varients
        static string name = "";
        static string streetAddress = "";
        static string city = "";
        static string state = "";
        static string zip = "";
        static int shirtCount = 0;

        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Clear();
                InputName();
                InputStreetAddress();
                InputCity();
                InputState();
                InputZip();
                InputShirt();

                printAllInfo();
            }

            
        }

        static void InputName()
        {
            Write("\nPlease Enter Your Name:\t");
            name = ReadLine();
        }

        static void InputStreetAddress()
        {
            Write("\nPlease Enter Your Street Address:\t");
            streetAddress = ReadLine();
        }

        static void InputCity() 
        {
            Write("\nPlease Enter Your City:\t");
            city = ReadLine();
        }

        static void InputState() 
        {
            Write("\nPlease Enter Your Sate:\t");
            state = ReadLine();
        }

        static void InputZip()
        {
            Write("\nPlease Enter Your Zip:\t");  
            zip = ReadLine();
        }

        static void InputShirt()
        {
            Write("\nHow many Shirts did you want to order?\t");
            if (int.TryParse(ReadLine(), out int shirts))
            {
                shirtCount = shirts;
            }

            else
            {
                WriteLine("Invalid Input. Please Enter A Valid Number.");
            }
        }

        static void printAllInfo()
        {
            string outputStr = $"Receipt For:\t\t";
            outputStr += $"\n{name}";
            outputStr += $"\n{streetAddress}";
            outputStr += $"\n{city}, {state} {zip}";

            decimal totalCost = shirtCount * SHIRTPRICE;
            decimal totalCostWithTax = totalCost * (1 + SALESTAX);

            WriteLine($"\nReciept For:");
            WriteLine($"{name}\t\t");
            WriteLine($"{streetAddress}");
            WriteLine($"{city}, {state} {zip}");

            WriteLine($"\n{shirtCount} T-Shirts Ordered At $14.99 Each.\t\t");

            WriteLine($"\nTotal:{totalCost:C}");
            WriteLine($"Tax:{totalCostWithTax - totalCost:C}");
            WriteLine($"Due:{totalCostWithTax:C}");

            ReadLine();
        }
    }

}
