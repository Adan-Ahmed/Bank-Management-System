using System;
// call list library
using System.Collections.Generic;
class Program
{
    // Take account information from user
    static Account Input_User(int accountnumber)
    {
        Console.WriteLine("Enter your Account Name");
        string accountname = Console.ReadLine();

        double accountbalance;
        while (true) 
        {
            Console.WriteLine("Enter your Account Balance");
            if (double.TryParse(Console.ReadLine(), out accountbalance))
            {
                if (accountbalance >= 0)
                {
                    break;
                }
                
                Console.WriteLine("Initial Balance Cannot Be Negative");
            }
            else
            {
                Console.WriteLine("Please enter a valid number for balance");
            }
        }

        // Create Account object
        Account account = new Account(
            accountnumber,
            accountname,
            accountbalance
        );

        return account;
    }

    static Account GetAccount(Bank bank) 
    {
        while (true) 
        {
            Console.WriteLine("Enter Account Number");
            if (int.TryParse(Console.ReadLine(), out int accountnumber)
            {
                Account account = bank.FindAccount(accountnumber);
                if(account != null)
                {
                    return account;
                }
                Console.WriteLine("Account Not Found");
            }
            else 
            {
                Console.WriteLine("Invalid Account Number");
            }
        }
    }

    static void Main(string[] args)
    {
        Bank bank = new Bank();

        while (true) 
        {
            Console.WriteLine();
            Console.WriteLine("===== Bank Management System =====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Transfer Money");
            Console.WriteLine("6. Apply Interest");
            Console.WriteLine("7. Account Details");
            Console.WriteLine("8. Exit");

            int choice;
            while (true)
            {
                Console.WriteLine("Enter your choice");

                if (int.TryParse(Console.ReadLine(), out choice)) 
                {
                    break;
                }
                Console.WriteLine("Please enter valid number");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Create Account selected");

                    int accountnumber;
                    while (true) 
                    { 
                        Console.WriteLine("Enter your account number");
                        if(int.TryParse(Console.ReadLine(), out accountnumber))
                        {
                            break;       
                        }
                        Console.WriteLine("Invalid Account Number");
                    }
                    Account existingaccount = bank.FindAccount(accountnumber);

                    if (existingaccount != null) 
                    {
                        Console.WriteLine("Account Already Exits");
                        break;
                  
                    }

                    Console.WriteLine("Select Account Type");
                    Console.WriteLine("1. Normal Account");
                    Console.WriteLine("2. Saving Account");

                    int accountType;
                    while (true) 
                    {
                        Console.WriteLine("Enter your choice");
                        if(int.TryParse(Console.ReadLine(), out accountType)) 
                        { 
                            if(accountType == 1 || accountType == 2) 
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Please select 1 or 2 ");
                    }
                    if (accountType == 1)
                    {
                        Account account = Input_User(accountnumber);
                        bank.AddAccount(account);
                        Console.WriteLine("Account Create Successfully");

                    }
                    else if (accountType == 2) 
                    {
                        Console.WriteLine("Enter your account name");
                        string accountname = Console.ReadLine();

                        Console.WriteLine("Ener your initial Balance");
                        double accountbalance = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter interest rate");
                        double interestrate = double.Parse(Console.ReadLine());

                        SavingsAccount savingsaccount = new SavingsAccount(
                            accountnumber,
                            accountname,
                            accountbalance,
                            interestrate
                        );
                        bank.AddAccount(savingsaccount);
                        Console.WriteLine("Savings Account create successfully");
                    }
                        break;

                case 2:
                    Console.WriteLine("Deposit selected");
                    Console.WriteLine();

                    while (true) 
                    {
                        Console.WriteLine("Enter your Account Number");
                        if (int.TryParse(Console.ReadLine(), out accountnumber))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter your valid account number");
                    }
                    Account foundAccount = bank.FindAccount(accountnumber);

                    if(foundAccount != null)
                    {
                        Console.WriteLine($"Account Name: {foundAccount.AccountName}");

                        double amount;
                        while (true) 
                        {
                            Console.WriteLine("Enter your Deposit");
                            if (double.TryParse(Console.ReadLine(), out amount)) 
                            {
                                break;
                            }
                            Console.WriteLine("Please enter correct deposit number");
                        }

                        bool success = foundAccount.Deposit(amount);
                        if (success)
                        {
                            Console.WriteLine("Deposit Successful");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Deposit");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");
                    }

                        break;

                case 3:
                    Console.WriteLine("Withdraw selected");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.WriteLine("Enter your Account Number");
                        if (int.TryParse(Console.ReadLine(), out accountnumber))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter your valid account number");
                    }
                    foundAccount = bank.FindAccount(accountnumber);

                    if (foundAccount != null)
                    {
                        Console.WriteLine($"Account Name: {foundAccount.AccountName}");
                        double amount;
                        while (true) 
                        {
                            Console.WriteLine("Enter your WithDraw Amount");

                            if(double.TryParse(Console.ReadLine(), out amount)) 
                            {
                                break;
                            }
                            Console.WriteLine("Please enter valid WithDraw Amount");
                        }

                        bool success = foundAccount.Withdraw(amount);
                        if (success)
                        {
                            Console.WriteLine("WithDraw Successful");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Withdraw Amount");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");
                    }

                    break;

                case 4:
                    Console.WriteLine("Check Balance selected");
                    Console.WriteLine();

                    Account account = GetAccount(bank);

                    Console.WriteLine($"Account Name: {account.AccountName}");
                    Console.WriteLine($"Current Balance: {account.CheckBalance()}");

                    break;

                case 5:
                    //sender amount
                    Console.WriteLine("Transfer Money selected");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.WriteLine("Enter your Account Number");
                        if (int.TryParse(Console.ReadLine(), out accountnumber))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter your valid account number");
                        
                    }

                    Account sender = bank.FindAccount(accountnumber);

                    if (sender != null)
                    {
                        Console.WriteLine($"Account Name: {sender.AccountName}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");
                        break;
                    }

                    //receiver amount 
                    Console.WriteLine("Enter the receiver account number");
                    Console.WriteLine();

                    int receiverAccountNumber;
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out receiverAccountNumber))
                        {
                            break;
                        }
                        Console.WriteLine("Please Enter valid receiver account number");
                    }

                    Account receiverAccount = bank.FindAccount(receiverAccountNumber);

                    if (receiverAccount != null)
                    {
                        Console.WriteLine($"Account Name: {receiverAccount.AccountName}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Receiver Account Number");
                        break;
                    }

                    //sender amount
                    Console.WriteLine("Enter the amount you want to send");
                    Console.WriteLine();
                    double Tamount;
                    while (true)
                    {
                        if(double.TryParse(Console.ReadLine(),out Tamount)) 
                        {
                            break;
                        }
                        Console.WriteLine("Enter the correct amount number");
                    }

                    bool sucess = sender.Transfer(receiverAccount,Tamount);
                    if (sucess) 
                    {
                        Console.WriteLine("Transfer Successful");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Transfer Amount or Insufficient Balance");
                    }
                        break;

                case 6:
                    Account account = GetAccount(bank);

                    if (account is SavingsAccount savingsAccount)
                    {
                        Console.WriteLine($"Account Name: {savingsAccount.AccountName}");
                        Console.WriteLine($"Current Balance: {savingsAccount.CheckBalance()}");

                        savingsAccount.AddInterest();

                        Console.WriteLine("Interest Applied Successfully");
                        Console.WriteLine($"New Balance: {savingsAccount.CheckBalance()}");
                    }
                    else
                    {
                        Console.WriteLine("Interest can only be applied to a Savings Account");
                    }

                    break;

                case 7:
                    Console.WriteLine("Account Details selected");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.WriteLine("Enter your Account Number");
                        if (int.TryParse(Console.ReadLine(), out accountnumber))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter your valid account number");
                    }
                    foundAccount = bank.FindAccount(accountnumber);

                    if (foundAccount != null)
                    {
                        Console.WriteLine($"Account Number: {foundAccount.AccountNumber}");
                        Console.WriteLine($"Account Name: {foundAccount.AccountName}");
                        Console.WriteLine($"Account Balance: {foundAccount.AccountBalance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");
                    }

                    break;

                case 8:
                    Console.WriteLine("Thank you for using Bank Management System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

    }  
    
}