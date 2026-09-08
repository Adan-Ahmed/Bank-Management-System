using System;
// call list library
using System.Collections.Generic;

class Account
{
    public int AccountNumber { get; set; }
    public string AccountName { get; set; }
    public double AccountBalance { get; set; }

    // Constructor
    public Account(int accountnumber, string accountname, double accountbalance)
    {
        AccountNumber = accountnumber;
        AccountName = accountname;
        AccountBalance = accountbalance;
    }

    // Deposit money
    public bool Deposit(double Damount)
    {
        if (Damount > 0)
        {
            
            AccountBalance = AccountBalance + Damount;
            return true;
        }
        else
        {
            return false;
        }
    }

    // Withdraw money
    public bool Withdraw(double Wamount)
    {
        if (AccountBalance >= Wamount && Wamount > 0)
        {
            AccountBalance -= Wamount;
            return true;
        }
        else
        {
            return false;
        }
    }

    // Check balance
    public double CheckBalance()
    {
        return AccountBalance;
    }
}

class Program
{
    // Take account information from user
    static Account Input_User()
    {
        Console.WriteLine("Enter your Account Number");
        int accountnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your Account Name");
        string accountname = Console.ReadLine();

        double accountbalance;
        while (true) 
        {
            Console.WriteLine("Enter your Account Balance");
            accountbalance = Convert.ToDouble(Console.ReadLine());
            if(accountbalance >= 0)
            {
                break;
            }
                Console.WriteLine("Initial Balance Cannot Be Negative");
        }

        //Console.WriteLine("Enter the deposit Amount");
        //double depositamount = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter the withdraw Amount");
        //double withdrawamount = Convert.ToDouble(Console.ReadLine());

        // Create Account object
        Account account = new Account(
            accountnumber,
            accountname,
            accountbalance
        );

        //// Deposit
        //account.Deposit(depositamount);

        //// Withdraw
        //account.Withdraw(withdrawamount);

        return account;
    }

    class Bank
    {
        // Bank owns the list of accounts
        List<Account> accounts = new List<Account>();

        // Add account to the bank
        public void Addaccount(Account account)
        {
            accounts.Add(account);
        }

        // Find account by account number
        public Account FindAccount(int accountnumber)
        {
            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountnumber)
                {
                    return account;
                }
            }

            return null;
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
            Console.WriteLine("5. Account Details");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Create Account selected");
                    Account account = Input_User();
                    Account existingaccount = bank.FindAccount(account.AccountNumber);

                    if (existingaccount == null)
                    {
                        bank.Addaccount(account);
                        Console.WriteLine("Account Create Successfully");                    
                    }
                    else
                    {
                        Console.WriteLine("Account ALready Exits");
                    }
                        break;

                case 2:
                    Console.WriteLine("Deposit selected");
                    Console.WriteLine();

                    Console.WriteLine("Enter your Account Number");
                    int accountnumber = Convert.ToInt32(Console.ReadLine());

                    Account foundAccount = bank.FindAccount(accountnumber);

                    if(foundAccount != null)
                    {
                        Console.WriteLine($"Account Name: {foundAccount.AccountName}");
                        Console.WriteLine("Enter your Deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());

                        bool success = foundAccount.Deposit(amount);
                        if (success)
                        {
                            Console.WriteLine("Deposit Successful")
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

                    Console.WriteLine("Enter your Account Number");
                    accountnumber = Convert.ToInt32(Console.ReadLine());

                    foundAccount = bank.FindAccount(accountnumber);

                    if (foundAccount != null)
                    {
                        Console.WriteLine($"Account Name: {foundAccount.AccountName}");
                        Console.WriteLine("Enter your WithDraw Amount");
                        double amount = Convert.ToDouble(Console.ReadLine());

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

                    Console.WriteLine("Enter your Account Number");
                    accountnumber = Convert.ToInt32(Console.ReadLine());

                    foundAccount = bank.FindAccount(accountnumber);

                    if(foundAccount != null) 
                    {
                        Console.WriteLine($"Account Name: {foundAccount.AccountName}");
                        Console.WriteLine($"Current Balance: {foundAccount.CheckBalance()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");

                    }

                    break;

                case 5:
                    Console.WriteLine("Account Details selected");
                    Console.WriteLine();

                    Console.WriteLine("Enter your Account Number");
                    accountnumber = Convert.ToInt32(Console.ReadLine());
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

                case 6:
                    Console.WriteLine("Thank you for using Bank Management System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        // Create 3 accounts
        //for (int i = 0; i < 3; i++)
        //{
        //    Account account = Input_User();

        //    // Add account to Bank
        //    bank.Addaccount(account);

        //    // Check current balance
        //    double balance = account.CheckBalance();

        //    Console.WriteLine($"Current Balance: {balance}");
        //    Console.WriteLine();
        //}

        // Search account
        //Console.WriteLine("Enter the Account Number to Search");
        //int SearchNum = Convert.ToInt32(Console.ReadLine());

        //Account foundaccount = bank.FindAccount(SearchNum);

        //// Display account information
        //if (foundaccount != null)
        //{
        //    Console.WriteLine($"Account Number: {foundaccount.AccountNumber}");
        //    Console.WriteLine($"Account Name: {foundaccount.AccountName}");
        //    Console.WriteLine($"Account Balance: {foundaccount.AccountBalance}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Account Number");
        //}
    }  
    
}