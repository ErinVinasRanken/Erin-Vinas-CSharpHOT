using System;

namespace LoanLibrary
{
    public class Validator
    {
        public static bool IsPresent(string value, string name)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool IsInt32(string value, string name)
        {
            return int.TryParse(value, out _);
        }

        public static bool IsDecimal(string value, string name)
        {
            return decimal.TryParse(value, out _);
        }

        public static bool IsWithinRange(string value, string name, decimal min, decimal max)
        {
            if (!decimal.TryParse(value, out decimal numericValue))
            {
                return false;
            }

            return numericValue >= min && numericValue <= max;
        }
    }
}
