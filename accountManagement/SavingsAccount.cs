namespace AccountManagementSystem
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double interestRata = 0.0) : base(name, balance)
        {
            InterestRata = interestRata;
        }

        public double InterestRata { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, InterestRata: {InterestRata}";
        }
    }
}
