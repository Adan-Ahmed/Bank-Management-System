public class SavingsAccount : Account
{
    public double InterestRate {  get; set; }
    public SavingsAccount(
        int accountnumber,
        string accountname,
        double accountbalance)
        : base(accountnumber, accountname, accountbalance)
    {
        InterestRate = interestrate;
    }
    public void AddInterest() 
    {
        double interest = AccountBalance * InterestRate / 100;
        AccountBalance += interest;
    }
}