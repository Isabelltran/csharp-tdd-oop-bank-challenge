using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Boolean.CSharp.Main.Abstract
{
    public abstract class BankAccount
    {
        private decimal _balance = 0;
        private Branch _branch;
        private List<Payment> _payments = new List<Payment>();

        public List<Payment> GetPaymentsHistory() => _payments; // Maybe remove later

        public bool AddPayment(Payment payment)
        {
            _payments.Add(payment);
            return true;
        }

        public void MakeDeposit(decimal amount)
        {
            _balance += amount;
        }

        public void MakeWithdraw(decimal amount)
        {
            _balance -= amount;
        }

        public string SeeTransactions()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"{"Date",-15}     || {"Credit",-15} || {"Debit",-15} || {"Balance",-15}");

            foreach (Payment p in _payments)
            {
                if (p.PaymentType == Type.Credit)
                {
                    MakeDeposit(p.Amount);
                    sb.Append($"\n{p.Date,-15} || {p.Amount,-15} || {"",-15} || {Balance,-15}");

                }
                if (p.PaymentType == Type.Debit)
                {
                    MakeWithdraw(p.Amount);
                    sb.Append($"\n{p.Date,-15} || {"",-15} || {p.Amount,-15} || {Balance,-15}");
                }
            }

            return sb.ToString();
        }

        public decimal Calculate ()
        {
            decimal balance = 0;
            foreach (Payment p in _payments)
            {
                if (p.PaymentType == Type.Credit && p.Amount != 0)
                {
                    balance += p.Amount;
                }
                if (p.PaymentType == Type.Debit && p.Amount != 0)
                {
                    balance -= p.Amount;
                }
            }
            return balance;
            
        }


        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid AccountNumber { get; set; } = Guid.NewGuid();

        public Branch Branch { get { return _branch;  } set { _branch = value; } }

        public string CustomerName { get; set; }
        public string BankAccountName { get; set; }

        public decimal Balance { get { return _balance; }  } 
    }
}
