using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Concrete.Accounts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void TestCalculate()
        {
            CurrentAccount account = new CurrentAccount();
            Payment p = new Payment(account, 500, Main.Type.Credit);
            Payment p1 = new Payment(account, 200, Main.Type.Debit);
            for (int i = 0; i < 5; i++)
            {
                account.AddPayment(p);
            }
            for (int i = 0; i < 3; i++)
            {
                account.AddPayment(p1);
            }
            decimal result = account.Calculate();

            Assert.That(result, Is.EqualTo(1900));

        }


        [Test]
        public void TestBranches()
        {
            CurrentAccount account = new CurrentAccount();
            SavingsAccount savingsAccount = new SavingsAccount();   

            account.Branch = Branch.Buskerud;
            savingsAccount.Branch = Branch.Oslo;

            Assert.That(account.Branch, Is.EqualTo(Branch.Buskerud));
            Assert.That(savingsAccount.Branch, Is.EqualTo(Branch.Oslo));

        }

        [Test]

        public void TestRequestOverdraft()
        {
            CurrentAccount current = new CurrentAccount();

            current.MakeDeposit(500);
            current.MakeWithdraw(1000);

            Overdraft result = current.RequestOverdraft(1000);

            Assert.That(result.Type, Is.EqualTo(SendingType.Accept));
            Assert.That(current.Balance, Is.EqualTo(500));

        }
        
    }
}
