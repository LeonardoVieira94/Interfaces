using System.Globalization;
using Interfaces2.Entities;
using Interfaces2.Services;


namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, totalValue);

            InstallmentService installmentService = new InstallmentService(installments, new PaypalService());
            installmentService.ProcessingInstallment(contract);


            Console.WriteLine("INSTALLMENTS:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
