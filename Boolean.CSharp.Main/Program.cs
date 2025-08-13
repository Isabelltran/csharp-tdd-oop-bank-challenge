// See https://aka.ms/new-console-template for more information
using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Abstract;
using Boolean.CSharp.Main.Concrete.Accounts;
using Type = Boolean.CSharp.Main.Type;

BankAccount savings = new SavingsAccount();
Payment payment = new Payment(savings, 1000, Type.Credit);
Payment payment1 = new Payment(savings, 1000, Type.Debit);
savings.AddPayment(payment);
savings.AddPayment(payment1);


Console.WriteLine(savings.SeeTransactions());


