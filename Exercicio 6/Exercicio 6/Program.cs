using System;
using System.Globalization;
namespace Exercicio_6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.QuantDolarComprar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.ValorASerPago().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
