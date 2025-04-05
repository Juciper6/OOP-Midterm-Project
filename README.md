# OOP-Midterm-Project

Card Account System
Overview
Card Account System is a simple C# console-based banking application that demonstrates Object-Oriented Programming (OOP) principles, including Encapsulation, Inheritance, Polymorphism, and Abstraction.

Features
User Authentication: Log in with a fixed admin account or create a new user account.
Account Types: Choose between Savings Account (with interest and withdrawal limits) or Checking Account (unlimited withdrawals).
Transactions: Perform deposits, withdrawals, and view account details.
OOP Implementation
Encapsulation: Private and Protected fields with controlled access.
Inheritance: Savings and Checking accounts inherit from a base Card class.
Polymorphism: Different behavior for Withdraw() and Deposit() in Savings and Checking accounts.
Abstraction: Simplified user interface for managing accounts.

Installation & Setup
Open the project in Visual Studio or any C# IDE.
Build the project to restore dependencies.
Run the project to start the console application.
Follow the on-screen prompts to create an account, select an account type, and perform transactions.
Enjoy the card system!

Testing & Edge Cases
Test Case 1: Login with Fixed Admin Account
Username: Team7
Password: JJDM 
Expected Output: Successfully logs in as set account.

Test Case 2: Deposit a Negative Amount
Input: Deposit -100
Expected Output: Error message preventing negative deposits.

Test Case 3: Withdraw More Than Available Balance
Input: Withdraw 15000 (when balance is 500)
Expected Output: Error message indicating insufficient funds.

Test Case 4: Exceed Savings Account Monthly Withdrawal Limit
Input: Make 4 withdrawals in a month (limit is 3)
Expected Output: Error message blocking additional withdrawals.

Test Case 5: Check Interest Earned on Savings Account
Input: Deposit 2000 and receive interest based on 10%
Expected Output: Receive 10 interest after the deposit.
Expected Output: Total balance should be 2010.

Test Case 6: Overdraft on Checking Account
Input: Withdraw 10500 from a Checking Account with 500 balance
Expected Output: Successful withdrawal with negative balance allowed.
Expected Output: Balance should be -10000.
Expected Output: No error message for overdraft.

Test Case 7: Overdraft error on Checking Account
Input: Withdraw more than the negative balance on a Checking Account [10000]
Expected Output: Error message indicating overdraft limit reached.
Notes
Savings accounts earn 10% interest on deposits and have a 5-withdrawal limit per month.
Checking accounts allow unlimited withdrawals but do not earn interest.

Created by

Deligero , Juspher
Bayubay , Jefel
Rallos , Mern Daniel

License
This project is servce for educational purposes only and OOP project.
