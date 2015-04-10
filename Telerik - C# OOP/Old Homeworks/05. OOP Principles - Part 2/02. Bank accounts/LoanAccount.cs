using System;
using System.Security.Policy;

namespace _02.Bank_accounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Bank inputBank, Customer inputCustomer, decimal inputBalance, decimal inputInterestRate)
            : base(inputBank, inputCustomer, inputBalance, inputInterestRate)
        {
            
        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (base.Customer is Company)
            {
                if (months > 2)
                {
                    return (months - base.Customer.LoanPeriod)*base.InterestRate*base.Balance;
                }
            }
            else if (base.Customer is Individual)
            {
                if (months > 3)
                {
                    return (months - base.Customer.LoanPeriod)*base.InterestRate*base.Balance;
                }
            }
            else
            {
                throw new Exception();
            }
            return 0;
        }
    }
}