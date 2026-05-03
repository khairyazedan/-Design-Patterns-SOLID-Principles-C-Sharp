using System;

namespace Encapsulation;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if(amount < 0)
        {
            throw new ArgumentException("Deposit amount must be psitive");
        }
        else
        {
           this.balance += amount;
        }
    }
    public void Wethdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
        else if(amount > balance)
        {
            throw new ArgumentException("Not enough cash!");
        }
        else
        {
           this.balance -= amount;
        }
    }

}
