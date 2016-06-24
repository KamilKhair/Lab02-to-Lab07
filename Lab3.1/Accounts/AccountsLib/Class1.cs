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
            if (!(amount > 0)) return false;
            _balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (!(_balance > amount)) return false;
            _balance -= amount;
            return true;
        }

        public bool Transfer(Account distenationAcc, double amount)
        {
            if (!(_balance >= amount)) return false;
            distenationAcc._balance += amount;
            _balance -= amount;
            return true;
        }
    }
}
