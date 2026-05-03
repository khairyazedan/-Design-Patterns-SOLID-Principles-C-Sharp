using Encapsulation;
using System;

Console.WriteLine("Hello, World!");
BadBankAccount badBankAccount = new BadBankAccount();
badBankAccount.balance=100;
Console.WriteLine(badBankAccount.balance);

BankAccount bankAccount = new BankAccount(55); //initial amount fo balance
Console.WriteLine($"balance = {bankAccount.GetBalance()}");
bankAccount.Deposit(700);
Console.WriteLine($"balance = {bankAccount.GetBalance()}");
//bankAccount.Deposit(-30);
bankAccount.Wethdraw(500);
Console.WriteLine($"balance = {bankAccount.GetBalance()}");

BankAccount bankAccount2 = new BankAccount(3000); //initial amount fo balance
Console.WriteLine($"balance2 = {bankAccount2.GetBalance()}");
bankAccount2.Deposit(700);
bankAccount2.Wethdraw(300); 
Console.WriteLine($"balance2 = {bankAccount2.GetBalance()}");

