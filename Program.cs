using System;

class Account
{
    public int Account_Number { get; set; }
    public string Account_Name { get; set; }
    public double Account_Balance { get; set; }
}

class Program 
{
static void Main(string[] args)
{
        Account account = new Account();
        account.Account_Number = 19209;
        account.Account_Name = "Adan";
        account.Account_Balance = 10000;

        Console.WriteLine(account.Account_Name);
        Console.WriteLine(account.Account_Balance);
        Console.WriteLine(account.Account_Number);
}
}