using System;

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance) => balance = initialBalance;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
            Console.WriteLine("Insufficient funds!");
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
        }
    }

    static void Main()
    {
        BankAccount account = new BankAccount(500);
        account.Deposit(200);
        account.Withdraw(100);
        account.Withdraw(700);
    }
}
