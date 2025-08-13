using Boolean.CSharp.Main.Abstract;
using Boolean.CSharp.Main.Concrete.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Overdraft
    {
        private CurrentAccount _account;
        private decimal _amount;
        private SendingType _type = SendingType.Pending;


        public Overdraft(CurrentAccount account, decimal amount) 
        {
            _account = account;
            _amount = amount;
        }

        public SendingType Type { get { return _type; } set { _type = value; } }

    }
}
