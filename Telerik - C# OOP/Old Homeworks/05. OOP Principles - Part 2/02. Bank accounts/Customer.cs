namespace _02.Bank_accounts
{
    public abstract class Customer
    {
        private string name;
        public int LoanPeriod { get; protected set; }
        //public Customer(string inputCustomerName, Bank inputBank, Customer inputCustomer, decimal inputBalance, decimal inputInterestRate)
        //    : base(inputBank, inputCustomer, inputBalance, inputInterestRate)
        //{
        //    this.Name = inputCustomerName;
        //}
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}