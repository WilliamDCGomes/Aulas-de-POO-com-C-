using System;
using System.Globalization;
namespace Calculadora {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Calc.Circuferencia(raio);
            double volume = Calc.Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calc.Pi.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
