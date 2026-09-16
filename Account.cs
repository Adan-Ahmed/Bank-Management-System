public class Account
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

    public bool Transfer(Account receiver, double amount)
    {
        if (amount > 0 && AccountBalance >= amount)
        {
            AccountBalance -= amount;
            receiver.AccountBalance += amount;
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