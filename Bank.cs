class Bank
{

    // Bank owns the list of accounts
    private List<Account> accounts = new List<Account>();


    // Add account to the bank
    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    // Find account by account number
    public Account? FindAccount(int accountnumber)
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