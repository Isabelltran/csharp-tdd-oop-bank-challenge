using Boolean.CSharp.Main.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Concrete.Accounts
{
    public class CurrentAccount : BankAccount
    {
        

        public override bool MakeWithdraw(decimal amount)
        {
            if (Balance < amount)
            {
                Overdraft overdraft = RequestOverdraft(amount - Balance);
                if (overdraft.Type == SendingType.Accept)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            else 
            {
                Balance -= amount;
                return true;
            }
        }
       public Overdraft RequestOverdraft(decimal amount)
        {
            Overdraft overdraft = new Overdraft(this, amount);
            if (amount <= Balance * 2)
            {
                overdraft.Type = SendingType.Accept;
            }
            else
            {
                overdraft.Type = SendingType.Reject;
            }

                return overdraft;
        }

    }
}
