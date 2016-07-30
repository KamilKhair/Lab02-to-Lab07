namespace AccountsLib
{
    //Nice
    public class Account
    {
        internal Account(int id)
        {
            Id = id;
            Balance = 0;
        }

        public int Id { get; }

        public double Balance { get; private set; }

        public bool Deposit(double amount)
        {

            //return amount <= 0 is more clrearer
            if (!(amount > 0)) return false;
            Balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (!(Balance > amount && amount > 0)) return false;
            Balance -= amount;
            return true;
        }

        public bool Transfer(Account destinationAcc, double amount)
        {
            if (!(Balance >= amount && amount > 0)) return false;
            destinationAcc.Balance += amount;
            Balance -= amount;
            return true;
        }
    }
}
