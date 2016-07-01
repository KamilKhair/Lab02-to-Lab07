namespace AccountsLib
{
    public static class AccountFactory
    {
        public static Account CreateAccount(int id, double balance)
        {
            var account = new Account(id);
            account.Deposit(balance);
            return account;
        }
    }
}