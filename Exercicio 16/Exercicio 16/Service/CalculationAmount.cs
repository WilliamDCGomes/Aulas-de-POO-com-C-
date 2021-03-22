using Exercicio_16.Entities;
using System.Globalization;
using System;

namespace Exercicio_16.Service {
    class CalculationAmount {
        public Installment MakeContract(Contract contract, int actualInstallments, int numberInstallments) {
            double parcialValue = contract.TotalValue/numberInstallments + (((contract.TotalValue / numberInstallments) * 0.01) * actualInstallments);
            double finalValue = parcialValue + (parcialValue * 0.02);
            CalculateDate calculateDate = new CalculateDate();
            DateTime dateContract = calculateDate.installmentsDate(actualInstallments, contract.Date);
            Installment installment = new Installment(dateContract, finalValue.ToString("F2", CultureInfo.InvariantCulture));
            return installment;
        }
    }
}
