namespace Exercicio_13.Entities {
    class TotalTaxes {
        public double TotalOfTaxesPaid { get; set; }

        public TotalTaxes(int taxe) {
            TotalOfTaxesPaid = taxe;
        }

        public void Total(double taxes) {
            TotalOfTaxesPaid += taxes;
        }
        public double ReturnTotal() {
            return TotalOfTaxesPaid;
        }
    }
}
