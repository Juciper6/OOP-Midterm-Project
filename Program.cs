using System;

//base class or parent class
abstract class Banking
{
    protected int Balance;
    private string Username;
    private string Password;
    private string AccountHolderName;
    private string nameCheckings;
    private string nameSavings;

    public Banking(string username, string password) // Constructor for the base class
    {
        Balance = 500;
        Username = username;
        Password = password;
        AccountHolderName = "\nAccount Holder name: [ DELIGERO RALLOS BAYUBAY ]";//can change depending on user/pede ma ilisan dpendi kung unsa imo i user
        nameCheckings = "\nTEAM 7 [Checkings Account]\n";
        nameSavings = "\nTEAM 7 [Savings Account]\n";
    }

    // Abstract methods to be implemented by derived classes/methods para ma sugo ang system/project og iyang classes
    public abstract void CheckBalance();
    public abstract void DepositMoney();
    public abstract void WithdrawMoney();

    // Method to check if the user is valid/ usa ka metod para makita ang user if sakto ba siya or dili or naa ba siyay account
    public bool IsValidUser(string username, string password)
    {
        return this.Username == username && this.Password == password;
    }

    // Main menu for the card account system / UI/ User Interface mao ni imo makita inig una nimong gamit sa system
    public void Index()
    {
        AccountInfos accountInfos = new AccountInfos();
        while (true)
        {
            Console.WriteLine(new string('+', 120));
            Console.WriteLine("\nWELCOME TO CARD ACCOUNT SYSTEM");
            if (this is CheckingAccount name1)
            {
                Console.WriteLine(name1.nameCheckings);
                Console.WriteLine("1. Check Account Balance\t2. Deposit Money\t3. Withdraw Money\t4. Check Account Info\t5. Log-out\n");
                Console.WriteLine(new string('+', 120));
            }
            else if (this is SavingsAccount name2)
            {
                Console.WriteLine(name2.nameSavings);
                Console.WriteLine("1. Check Account Balance\t2. Deposit Money\t3. Withdraw Money\t4. Check Account Info\t5. Log-out\n");
                Console.WriteLine(new string('+', 120));
            }
            Console.Write("\nENTER NUMBER FOR SELECTION: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    DepositMoney();
                    break;
                case "3":
                    WithdrawMoney();
                    break;
                case "4":
                    if (this is CheckingAccount checking)
                    {
                        Console.WriteLine(checking.AccountHolderName);
                        accountInfos.CheckingsAccount_Info();
                        Console.WriteLine($"Balance: PHP {checking.Balance}");// naa diri makita ang input sa balance sa check account
                        Console.Write("\nPRESS ENTER TO GO BACK TO MAIN MENU...");
                        Console.ReadLine();
                        Console.WriteLine("");
                        continue;
                    }
                    else if (this is SavingsAccount savings)
                    {
                        Console.WriteLine(savings.AccountHolderName);

                        accountInfos.SavingsAccount_Info();
                        Console.WriteLine($"Balance: PHP {savings.Balance}");// naa diri makita ang input sa balance sa save account
                        Console.Write("\nPRESS ENTER TO GO BACK TO MAIN MENU...");
                        Console.ReadLine();
                        Console.WriteLine("");
                        continue;
                    }
                    break;
                case "5":
                    Console.WriteLine("\nLogging out...\n");
                    return;
                default:
                    Console.Write("\nINVALID INPUT. PRESS ENTER TO GO BACK TO MAIN MENU...");
                    Console.ReadLine();
                    Console.WriteLine("");
                    break;
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        AccountInfos accountInfos = new AccountInfos();
        Banking banking;

        //Login and account selection 
        while (true)
        {
            Console.WriteLine(new string('+', 120));
            Console.WriteLine("\nTEAM 7 CARD ACCOUNT SYSTEM\n");
            Console.WriteLine("1. LOG - IN\t2. EXIT\n");
            Console.WriteLine(new string('+', 120));
            Console.Write("\nENTER NUMBER FOR SELECTION: ");
            string index = Console.ReadLine();

            switch (index)
            {
                case "1":
                    Console.Write("Choose Account Type (1: Checking, 2: Savings): ");
                    string accountType = Console.ReadLine();

                    if (accountType == "1")
                    {
                        accountInfos.CheckingsAccount_Info();

                        Console.Write("Do you want to proceed with a Checking Account? (Y/N): ");
                        string proceed = Console.ReadLine().ToUpper();
                        Console.WriteLine("");

                        if (proceed == "Y")
                        {
                            banking = new CheckingAccount("Team7", "JJMD");// mao ni atong account sa atong system , mailisan ra nimo og unsay prefer sa user,sa check account
                            Console.WriteLine(new string('+', 120));
                            Console.WriteLine("Checking Account Selected.");
                            Console.WriteLine(new string('+', 120));
                        }
                        else if (proceed == "N")
                        {
                            Console.Write("SELECTION CANCELED. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.Write("INVALID SELECTION. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                            Console.ReadLine();
                            continue;
                        }
                    }

                    else if (accountType == "2")
                    {
                        accountInfos.SavingsAccount_Info();

                        Console.Write("Do you want to proceed with a Savings Account? (Y/N): ");
                        string proceed = Console.ReadLine().ToUpper();
                        Console.WriteLine("");

                        if (proceed == "Y")
                        {
                            banking = new SavingsAccount("Team7", "JJMD");// mao ni atong account sa atong system , mailisan ra nimo og unsay prefer sa user,sa saving account
                            Console.WriteLine(new string('+', 120));
                            Console.WriteLine("Savings Account Selected.");
                            Console.WriteLine(new string('+', 120));
                        }
                        else if (proceed == "N")
                        {
                            Console.Write("SELECTION CANCELED. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.Write("INVALID SELECTION. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                            Console.ReadLine();
                            continue;
                        }
                    }

                    else
                    {
                        Console.Write("\nACCOUNT TYPE NOT FOUND. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("\nLOG - IN TO ACCESS YOUR CARD ACCOUNT\n");
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine(new string('+', 120));

                    if (banking.IsValidUser(username, password))
                    {
                        Console.WriteLine("\nLog-in Successful!\n");
                        banking.Index();
                    }
                    else
                    {
                        Console.Write("\nLog-in Failed. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                        Console.ReadLine();
                        Console.WriteLine("");
                    }
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine(new string('+', 120));
                    Console.WriteLine("Made by: TEAM 7");
                    Console.WriteLine(new string('+', 120));
                    Console.WriteLine("\nExiting...");
                    return;
                default:
                    Console.Write("\nINVALID INPUT. PRESS ENTER TO GO BACK TO LOG-IN SECTION...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
