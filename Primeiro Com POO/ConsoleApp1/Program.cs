using System;
using System.Globalization;
namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            x.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");               
            y.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float p1 = (float) (x.A + x.B + x.C) / 2;
            double area1 = (double) Math.Sqrt((p1 * (p1 - x.A) * (p1 - x.B) * (p1 - x.C)));
            float p2 = (float) (y.A + y.B + y.C) / 2;
            double area2 = (double) Math.Sqrt((p2 * (p2 - y.A) * (p2 - y.B) * (p2 - y.C)));
            Console.WriteLine("Valor área 1: " + area1.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor área 2: " + area2.ToString("F4",CultureInfo.InvariantCulture));
            if (area1 > area2) {
                Console.WriteLine("O triângulo 1 possui a área maior!");
            }
            else if (area2 > area1) {
                Console.WriteLine("O triângulo 2 possui a área maior!");
            }
            else {
                Console.WriteLine("Os triângulos possuem áreas iguais!");
            }
        }
    }
}
