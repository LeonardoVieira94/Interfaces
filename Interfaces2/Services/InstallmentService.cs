using Interfaces2.Entities;

namespace Interfaces2.Services
{
    internal class InstallmentService
    {
        public int Installments { get; set; }
        private ITaxService _taxService;

        public InstallmentService(int installments, ITaxService taxService)
        {
            Installments = installments;
            _taxService = taxService;
        }

        public void ProcessingInstallment(Contract contract)
        {
            double initialAmount = contract.TotalValue / Installments;

            for (int i = 1; i <= Installments; i++)
            {
                double interest = _taxService.Interest(initialAmount, i);
                double amount = _taxService.PaymentFee(interest);
                DateTime dueDate = contract.Date.AddMonths(i);
                Installment installment = new Installment(dueDate, amount);
                contract.AddContract(installment);
            }

        }

    }
}
