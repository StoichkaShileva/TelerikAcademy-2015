namespace _02.Bank_accounts
{
    public abstract class Account : Bank, IAccount
    {

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public Account(Bank inputBank)
            : base (inputBank.BankName)
        {
            
        }

        public Account(Bank inputBank, Customer inputCustomer, decimal inputBalance, decimal inputInterestRate)
            : this(inputBank)
        {
            this.Customer = inputCustomer;
            this.Balance = inputBalance;
            this.InterestRate = inputInterestRate;
        }

        public abstract decimal CalculateInterestAmount(int months);
    }
}