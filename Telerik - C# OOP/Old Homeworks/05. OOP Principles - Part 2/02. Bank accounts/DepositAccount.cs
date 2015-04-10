using System;

namespace _02.Bank_accounts
{
    public class DepositAccount : Account, IWithDraw
    {
        public DepositAccount(Bank inputBank, Customer account, decimal inputBalance, decimal inputInterestRate)
            : base(inputBank, account, inputBalance, inputInterestRate)
        {
            
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (base.Balance > 1000)
            {
                decimal temp = (base.Balance*base.InterestRate) / 100;
                return (temp*months) + base.Balance;
            }
            else if(base.Balance < 1000 && base.Balance > 0)
            {
                return 0;
            }
            else
            {
                throw new Exception();
            }
        }

        public void WithDraw(decimal amount)
        {
            base.Balance -= amount;
        }
    }
}