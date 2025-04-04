
//Inherits from the base class
using System;

class CheckingAccount : Banking
{
    private const int MinimumBalance = 500;  // Set a minimum balance requirement
    private const int OverdraftLimit = -10000; // Allow overdraft but up to a limit / technically murag utang or loan

    public CheckingAccount(string username, string password) : base(username, password) { }

    public override void CheckBalance()
    {
        Console.WriteLine("");
        Console.WriteLine(new string('+', 120));
        Console.WriteLine($"Your current balance is: PHP {Balance}");
        Console.Write("\nPRESS ENTER TO GO BACK TO MAIN MENU...");
        Console.ReadLine();
    }

    // Override the DepositMoney method to include overdraft protection
    public override void DepositMoney()
    {
        while (true)
        {
            Console.Write("\nEnter the amount you want to deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            if (deposit > 0)
            {
                Balance += deposit;
                Console.WriteLine($"\nYou have deposited: PHP {deposit}");
                Console.WriteLine($"Your new balance is: PHP {Balance}\n");
                return;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }
    }

    // Override the WithdrawMoney method to include overdraft protection
    public override void WithdrawMoney()
    {
        while (true)
        {
            Console.Write("\nEnter the amount you want to withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());

            if (withdraw <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
                continue;
            }

            if (Balance - withdraw < OverdraftLimit)
            {
                Console.WriteLine("\nOverdraft limit reached! Cannot withdraw.\n");
                return;
            }
            else if (Balance - withdraw < MinimumBalance)
            {
                Console.Write($"Warning: Your balance will go below PHP {MinimumBalance}. Are you sure? (Y/N) :");// which is mao ni katong pede natong mautang or loan
                string confirm = Console.ReadLine().ToUpper();
                if (confirm == "Y")
                {
                    Balance -= withdraw;
                    Console.WriteLine($"\nYou have withdrawn: PHP {withdraw}");
                    Console.WriteLine($"Your new balance is: PHP {Balance}\n");
                    return;
                }
                else
                {
                    Console.WriteLine("\nWithdrawal canceled.\n");
                    return;
                }
            }
            else
            {
                Balance -= withdraw;
                Console.WriteLine($"\nYou have withdrawn: PHP {withdraw}");
                Console.WriteLine($"Your new balance is: PHP {Balance}\n");
                return;
            }
        }
    }

}
