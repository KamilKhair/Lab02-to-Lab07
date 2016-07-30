namespace AccountsLib
{
    public static class AccountFactory
    {
        //Id should be created inside AccountFactory
        public static Account CreateAccount(int id, double balance)
        {
            var account = new Account(id);
            account.Deposit(balance);
            return account;
        }
    }
}