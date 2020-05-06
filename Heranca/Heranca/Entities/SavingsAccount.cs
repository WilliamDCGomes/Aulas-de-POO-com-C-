namespace Heranca.Entities {
    sealed class SavingsAccount : Account{
        public double InterestRate { get; set; }

        public SavingsAccount() {
        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance){
            InterestRate = interestRate;

            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
