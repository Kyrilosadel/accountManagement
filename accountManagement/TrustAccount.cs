namespace AccountManagementSystem
{
    internal class TrustAccount : SavingsAccount
    {
        private readonly double depositThreshold = 5000.0;
        private readonly double withdrawTriesThreshold = 3;
        private readonly double withdrawThreshold = 0.20;
        private int triesCounter = 0;
        private DateTime triesDate = DateTime.Now.Date;

        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double interestRata = 0.0) : base(name, balance, interestRata)
        {
        }

        public new bool Deposit(double amount)
        {
            if (amount > depositThreshold)
            {
                return base.Deposit(amount + depositThreshold);
            }

            return base.Deposit(amount);
        }

        public new bool Withdraw(double amount)
        {
            if (DateTime.Now.Date > triesDate.AddYears(1))
            {
                triesDate = DateTime.Now.Date;
                triesCounter = 0;
            }

            if (triesCounter <= withdrawTriesThreshold && amount < (Balance * withdrawThreshold))
            {
                triesCounter++;

                base.Withdraw(amount);
                return true;
            }

            return false;
        }

    }
}