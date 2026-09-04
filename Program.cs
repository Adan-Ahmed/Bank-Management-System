using System;

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

        Account account = new Account(accountnumber, accountname, accountbalance); // object create 
        
        //return object
        return account;
    }
static void Main(string[] args)
{
        //Account account = new Account(19209, "Adan", 10000);

        //if we are using constructor we didnot need to do this ↓ 
        //account.AccountNumber = 19209;
        //account.AccountName = "Adan";
        //account.AccountBalance = 10000;

        Account account = Input_User();

        Console.WriteLine(account.AccountName);
        Console.WriteLine(account.AccountBalance);
        Console.WriteLine(account.AccountNumber);
}
}