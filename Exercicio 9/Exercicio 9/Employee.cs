using System.Globalization;
namespace Exercicio_9 {
    class Employee {
        public string Id {get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(string id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            percentage = Salary * (percentage/100);
            Salary += percentage;
        }

        public override string ToString() {
            return Id + ", " + Name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
