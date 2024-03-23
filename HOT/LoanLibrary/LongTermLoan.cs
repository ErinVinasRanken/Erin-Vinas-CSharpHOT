using System;

namespace LoanLibrary
{
    public class LongTermLoan : ILoan
    {
        private string _name;
        private double _balance;

        public LongTermLoan(string name, double balance)
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
            get { return "Long-Term"; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void MakePayment(double amount)
        {
            double monthlyPayment = 200; 
            if (Balance >= monthlyPayment)
            {
                Balance -= monthlyPayment;
            }
        }

        public void ApplyInterest(double rate)
        {
            double monthlyInterestRate = 0.05;
            Balance *= (1 + monthlyInterestRate);
        }
    }
}
