using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Concrete.Accounts;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void TestCurrentAccount()
        {
            CurrentAccount current = new CurrentAccount();

            Assert.That(current, Is.Not.Null);
        }

        [Test]
        public void TestSavingsAccount()
        {
            SavingsAccount savingsAccount = new SavingsAccount();

            Assert.That(savingsAccount, Is.Not.Null);
        }

        [Test]
        public void TestStatements()
        {

        }

        [Test]
        public void TestDeposit()
        {
            SavingsAccount savings = new SavingsAccount();

            savings.MakeDeposit(1000);

            Assert.That(savings.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void TestWithdraw()
        {
            SavingsAccount savings = new SavingsAccount();

            savings.MakeDeposit(1000);
            savings.MakeWithdraw(500);

            Assert.That(savings.Balance, Is.EqualTo(500));
        }

    }
}