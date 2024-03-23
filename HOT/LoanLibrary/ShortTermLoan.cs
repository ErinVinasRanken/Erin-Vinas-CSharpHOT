using System;

namespace LoanLibrary
{
    public class ShortTermLoan : ILoan
    {
        private string _name;
        private double _balance;

        public ShortTermLoan(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return "Short-Term"; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void MakePayment(double amount)
        {
            double monthlyPayment = 450; 
            if (Balance >= monthlyPayment)
            {
                Balance -= monthlyPayment;
            }
        }

        public void ApplyInterest(double rate)
        {
            double monthlyInterestRate = 0.1; 
            Balance *= (1 + monthlyInterestRate);
        }
    }
}
