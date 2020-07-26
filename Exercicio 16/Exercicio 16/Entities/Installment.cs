using System;

namespace Exercicio_16.Entities {
    class Installment {
        public DateTime DueDate { get; set; }
        public String Amount { get; set; }

        public Installment(DateTime dueDate, String amount) {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString() {
            string date = DueDate.ToString("dd/MM/yyyy");
            return $"{date} - {Amount}";
        }
    }
}
