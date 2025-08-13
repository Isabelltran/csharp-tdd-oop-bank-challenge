| Classes				| Methods/Properties					| Scenario									| Outputs			|
|-----------------------|---------------------------------------|-------------------------------------------|-------------------|
|BankAccount			|CreateCurrentAccount()					| Create Current Account					| bool				|
|BankAccount			|CreateSavingsAccount()					| Create Savings Account					| bool				|
|BankAccount			|SeePayments()							| See statements with transaction			| DateTime, decimal	|			
|BankAccount			|Deposit(Account account, int amount)	| Deposit funds								| decimal			|
|BankAccount			|Withdraw(Account account, int amount)	| Withdraw funds							| decimal			|



```
As a customer,
So I can safely store use my money,
I want to create a current account.

As a customer,
So I can save for a rainy day,
I want to create a savings account.

As a customer,
So I can keep a record of my finances,
I want to generate bank statements with transaction dates, amounts, and balance at the time of transaction.

As a customer,
So I can use my account,
I want to deposit (legge inn/credit) and withdraw(tatt ut/debit) funds.
```
