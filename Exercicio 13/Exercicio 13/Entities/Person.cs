namespace Exercicio_13.Entities {
    class Person : TaxPayers{
        public double HealthExpenditures { get; set; }

        public Person(string name, double anualIncome, double healthExpenditures)
        : base (name, anualIncome){
            HealthExpenditures = healthExpenditures;
        }

        public override double taxesPaid() {
            if (AnualIncome < 20000.00) {
                if(HealthExpenditures > 0) {
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
                }
                else {
                    return AnualIncome * 0.15;
                }
            }
            else {
                if (HealthExpenditures > 0) {
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
                else {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}
