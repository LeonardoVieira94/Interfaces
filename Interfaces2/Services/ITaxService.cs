

namespace Interfaces2.Services
{
    internal interface ITaxService
    {
        double PaymentFee(double initialAmount);
        double Interest(double initialAmount, int Installment);
    }
}
