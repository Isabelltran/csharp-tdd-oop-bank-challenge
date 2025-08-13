using Boolean.CSharp.Main.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Payment
    {
        private BankAccount _account;
        private decimal _amount;
        private Type _paymentType;
        public Payment(BankAccount account, decimal amount, Type paymentType)
        {
            _account = account;
            _amount = amount;
            _paymentType = paymentType;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid Account {  get; set; }
        public Type PaymentType { get { return _paymentType; } }   
        public decimal Amount { get { return _amount; } }
        public DateTime Date {  get; set; } = DateTime.UtcNow;
    }
}
