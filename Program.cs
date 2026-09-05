using System;
// call list library
using System.Collections.Generic;

class Account
{
    public int AccountNumber { get; set; }
    public string AccountName { get; set; }
    public double AccountBalance { get; set; }

    //contructor
    public Account(int accountnumber, string accountname, double accountbalance)
    {
        AccountNumber = accountnumber;
        AccountName = accountname;
        AccountBalance = accountbalance;
    }

    public void Deposit(Double Damount)
    {
        AccountBalance = AccountBalance + Damount;
    }
    public void Withdraw(double Wamount)
    {
        if (AccountBalance >= Wamount)
        {
            Console.WriteLine("You can Withdraw the money");
            AccountBalance = AccountBalance - Wamount;
        }
        else
        {
            Console.WriteLine("Invalid Amount");
        }
    }
    public double CheckBalance()
    {
        return AccountBalance;
    }
}
class Program
{
        static Account Input_User()
        {
            Console.WriteLine("Enter your Account Number");
            int accountnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Account Name");
            string accountname = Console.ReadLine();

            Console.WriteLine("Enter your Account Balance");
            double accountbalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter the deposit Amount");
            double depositamount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter the with Draw Amount");
            double withdrawamount = Convert.ToDouble(Console.ReadLine());

            Account account = new Account(accountnumber, accountname, accountbalance); // object create 

            account.Deposit(depositamount);

            account.Withdraw(withdrawamount);

            return account;
        }

    static Account FinAccount(List<Account> accounts, int accountnumber)
    {
        return;
    }
        static void Main(string[] args)
        {
            //constuctor argument
            //Account account1 = new Account(19209, "Adan", 10000);
            //Account account2 = new Account(20212, "Taha", 35000);
            //Account account3 = new Account(20033, "Azzam", 4000.22);

            //if we are using constructor we didnot need to do this ↓ 
            //account.AccountNumber = 19209;
            //account.AccountName = "Adan";
            //account.AccountBalance = 10000;

            //static Account Input_User() call this method below
            //Account account1 = Input_User();
            //Account account2 = Input_User();
            //Account account3 = Input_User();



            List<Account> accounts = new List<Account>();

            //we are using for loop 
            for (int i = 0; i < 3; i++)
            {
                Account account = Input_User();
                accounts.Add(account);

                double balance = account.CheckBalance();
                Console.WriteLine($"Current Balance: {balance}");
            }

            //call the input user 
            //accounts.Add(account1);
            //accounts.Add(account2);
            //accounts.Add(account3);

            foreach (Account acc in accounts)
            {
                Console.WriteLine($"Account Number: {acc.AccountNumber}");
                Console.WriteLine($"Account Name: {acc.AccountName}");
                Console.WriteLine($"Account balance {acc.AccountBalance}");
            }
        }
}
