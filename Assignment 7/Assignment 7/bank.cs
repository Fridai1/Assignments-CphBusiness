#define CONTRACTS_FULL

using System.Diagnostics.Contracts;

namespace Assignment_7
{
    class Bank
    {
        private double _accountBalance = 10000;
        public double Deposit(double amount)
        {

            Contract.Requires(amount > 0,"amount was 0 or less");
            Contract.Ensures(_accountBalance == _accountBalance + amount,"the balance didn't match");
            _accountBalance += amount;
            return _accountBalance;

        }

        public double Withdraw(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Requires(_accountBalance >= amount);
            Contract.Ensures(_accountBalance == _accountBalance - amount);
            _accountBalance -= amount;
            return _accountBalance;
        }

        public double Balance { get => _accountBalance; }
    }
}
