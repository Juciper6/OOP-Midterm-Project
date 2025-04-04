
// Contains the information about the Savings and Checkings Account. ATONG UI or User Interface
using System;

public class AccountInfos
{
    public void SavingsAccount_Info()
    {
        Console.WriteLine("\nSavings Account Information\n");
        Console.WriteLine("- Minimum balance required: PHP 500.");
        Console.WriteLine("- Interest rate: 10% per deposit.");
        Console.WriteLine("- Withdrawal limit: 5 per month.");
        Console.WriteLine("- Best for savings and earning interest.Money Hacks :D\n");
    }
    public void CheckingsAccount_Info()
    {
        Console.WriteLine("\nChecking Account Information\n");
        Console.WriteLine("- Minimum balance required: PHP 500.");
        Console.WriteLine("- Overdraft protection: You can go negative up to PHP -10000.");
        Console.WriteLine("- Best for frequent withdrawals, payments, transfers , and last but not the least its fast.\n");
    }

}
