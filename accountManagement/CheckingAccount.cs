namespace AccountManagementSystem
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0, double fee = 0.0) : base(name, balance)
        {
            Fee = fee;
        }

        public double Fee { get; set; }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Fee: {Fee}";
        }
    }
}
