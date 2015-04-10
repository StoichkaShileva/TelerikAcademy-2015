using System;

namespace _02.Bank_accounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Bank inputBank, Customer inputCustomer, decimal inputBalance,
            decimal inputInterestRate)
            : base(inputBank, inputCustomer, inputBalance, inputInterestRate)
        {
            
        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (base.Customer is Company)
            {
                if(months > 6)
                    return this.InterestRate * (months - 6) * this.Balance;
            }
            else if (base.Customer is Individual)
            {
                if (months > 12)
                    return this.InterestRate*(months - 12)*this.Balance;
            }
            else
            {
                throw new Exception("Something wrong just happened");
            }
            return 0;
        }
    }
}