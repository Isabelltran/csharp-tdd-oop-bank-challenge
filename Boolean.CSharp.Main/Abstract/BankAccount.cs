using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Abstract
{
    public abstract class BankAccount
    {
        private List<Payment> _payments = new List<Payment>();

        public List<Payment> GetPaymentsHistory() => _payments;

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid AccountNumber { get; set; } = Guid.NewGuid();
        
        public string CustomerName { get; set; }
        public string BankAccountName { get; set; }

        public virtual void MakeDeposit() { }

        public virtual void MakeWithdraw() { }

        public virtual void SeeTransactions()
        {

        }

        //date       || credit  || debit  || balance
        //14/01/2012 ||         || 500.00 || 2500.00
        //13/01/2012 || 2000.00 ||        || 3000.00
        //10/01/2012 || 1000.00 ||        || 1000.00

    }
}
