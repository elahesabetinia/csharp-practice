using System;

class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance = 0)
    {
        Owner = owner;
        Balance = initialBalance < 0 ? 0 : initialBalance;
    }

    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return false;
        }
        Balance += amount;
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
            return false;
        }
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
        Balance -= amount;
        return true;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"{Owner}'s balance: {Balance}");
    }
}
