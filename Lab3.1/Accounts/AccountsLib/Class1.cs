namespace AccountsLib
{
    public class Account
    {
        readonly int _id;
        double _balance;
        internal Account(int id)
        {
            _id = id;
        }

        public int ID
        {
            get { return _id; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public bool Deposit(double amount)
        {
            try
            {
                if (amount > 0)
                {
                    _balance += amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Withdraw(double amount)
        {
            if (_balance > amount)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transfer(Account distenationAcc, double amount)
        {
            try
            {
                if (_balance >= amount)
                {
                    distenationAcc._balance += amount;
                    _balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }

    public static class AccountFactory
    {
        public static Account CreateAccount(int id, double balance)
        {
            Account account = new Account(id);
            account.Deposit(balance);
            return account;
        }
    }
}
