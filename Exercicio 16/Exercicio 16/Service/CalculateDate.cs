using System;

namespace Exercicio_16.Service {
    class CalculateDate {
        public DateTime installmentsDate(int installments, DateTime dateContract) {
            return dateContract.AddMonths(installments);
        }
    }
}
