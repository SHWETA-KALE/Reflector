using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflector
{
    internal class Account
    {

        private int _accountNumber;
        private string _name;
        private double _balance;

        public int AccountNumber { get; set; }
        public string Name { get; set; }

        static double Min_Balance = 500;

        public double Balance { get; set; } = Min_Balance;

        public string AadharNum { get; set; } //property

        //constructors

        public Account(int _accountNumber, string _name)
        {
            AccountNumber = _accountNumber;
            Name = _name;
        }

        public Account(int _accountNumber, string _name, double _balance) : this(_accountNumber, _name)
        {
            Balance = Min_Balance;
        }

        public Account(int _accountNumber, string _name, double _balance, string _aadharNum) : this(_accountNumber, _name, _balance)
        {
            AadharNum = _aadharNum;
        }

        public Account()
        {
        }
    }
}
