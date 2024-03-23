using System;

namespace LoanLibrary
{
    public interface ILoan
    {
        // Instance Variables
        string Name { get; }
        string Type { get; }
        double Balance { get; }

        void MakePayment(double amount);
        void ApplyInterest(double rate);
    }
}
