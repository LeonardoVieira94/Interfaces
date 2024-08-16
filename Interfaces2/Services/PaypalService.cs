using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Services
{
    internal class PaypalService : ITaxService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public PaypalService() 
        {
        }
        public double Tax(double initialAmount, int installment)
        {
            double initialTax = initialAmount + (initialAmount * MonthlyInterest * installment);
            return initialTax + initialTax * FeePercentage;
        }
    }
}
