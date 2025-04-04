

// Inherits from the base class
using System;

class SavingsAccount : Banking
{
    private const int MaxWithdrawalsPerMonth = 5;  // Limit number of withdrawals/kapila maka withdraw
    private const double InterestRate = 0.10; // 10% interest per deposit
    private int WithdrawalsThisMonth = 0; // Track monthly withdrawals
    public SavingsAccount(string username, string password) : base(username, password) { }

    public override void CheckBalance()
    {
        Console.WriteLine("");
        Console.WriteLine(new string('+', 120));
        Console.WriteLine($"Your current balance is: PHP {Balance}");
        Console.Write("\nPRESS ENTER TO GO BACK TO MAIN MENU...");
        Console.ReadLine();
    }

    // Override the DepositMoney method to include interest calculation
    public override void DepositMoney()
    {
        while (true)
        {
            Console.Write("\nEnter the amount you want to deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            if (deposit > 0)
            {
                double interest = deposit * InterestRate;// formula sa interert
                Balance += deposit + (int)interest; // Apply interest
                Console.WriteLine($"\nYou have deposited: PHP {deposit}");
                Console.WriteLine($"Interest earned: PHP {(int)interest}");
                Console.WriteLine($"Your new balance is: PHP {Balance}\n");
                return;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }
    }

    // Override the WithdrawMoney method to include withdrawal limit
    public override void WithdrawMoney()
    {
        while (true)
        {
            if (WithdrawalsThisMonth >= MaxWithdrawalsPerMonth)
            {
                Console.WriteLine("\nWithdrawal limit reached for this month. Try again next month.\n");//kapila maka withdraw which is kalima 5
                return;
            }

            Console.Write("\nEnter the amount you want to withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw > Balance)
            {
                Console.Write($"Current Balance: {Balance}\nInsufficient balance. Press Enter to go back to Main Menu...");
                Console.ReadLine();
                Console.WriteLine("");
                return;
            }
            else if (withdraw > 0)
            {
                Balance -= withdraw;
                WithdrawalsThisMonth++;
                Console.WriteLine($"\nYou have withdrawn: PHP {withdraw}");
                Console.WriteLine($"Your new balance is: PHP {Balance}");
                Console.WriteLine($"Withdrawals remaining this month: {MaxWithdrawalsPerMonth - WithdrawalsThisMonth}\n");
                return;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }
    }
}
