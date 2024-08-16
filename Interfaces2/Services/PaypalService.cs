

namespace Interfaces2.Services
{
    internal class PaypalService : ITaxService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public PaypalService() 
        {
        }

        public double PaymentFee(double amount)
        {
            return amount + FeePercentage * amount;
        }
        public double Interest(double initialAmount, int installment)
        {
            return initialAmount + (initialAmount * MonthlyInterest * installment);
   
        }
    }
}
