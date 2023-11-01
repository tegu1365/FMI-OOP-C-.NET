using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Account
    {
        #region Properties
        /// <summary>
        /// Backing field for AnualInterestRate
        /// </summary>
        private decimal anualInterestRate;
        private decimal balance;

        /// <summary>
        /// Full property, snippet propfull
        /// </summary>
        public decimal AnualInterestRate
        {
            get { return anualInterestRate; }
            set { anualInterestRate = value > 0m ? value : 0.01m; }
        }

        /// <summary>
        /// ID of Account
        /// read-only init property
        /// </summary>
        public string Id { get; init; }


        public decimal Balance
        {
            get { return balance; }
            set
            {
                balance = value >= 0m ? value : 0m;
            }
        }

        /// <summary>
        /// Init only property, snippet propi
        /// </summary>
        public DateTime DateCreated { get; init; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// snippet const
        /// </summary>
        public Account()
        {
            Id = "00000";
        }

        public Account(string id, decimal anualIntrestRate, decimal balance)
        {
            Id = id;
            AnualInterestRate = anualIntrestRate;
            Balance = balance;
            DateCreated = DateTime.Now;
        }
        #endregion


        #region Methods
        public void Deposit(decimal amountToDeposit)
        {
            if (amountToDeposit > 0)
            {
                balance += amountToDeposit;
            }
            else
            {
                Console.WriteLine($"Wrong input {amountToDeposit}.");
            }
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw>0)
            {
                if(balance - amountToWithdraw >= 0)
                {
                    balance -= amountToWithdraw;
                }
                else
                {
                    Console.WriteLine($"NO funds avaible to withdraw {amountToWithdraw}.");
                }
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}\nBalance: {balance:F}, rate: {(anualInterestRate * 100):F} %\n";
        }
        #endregion
    }
}
