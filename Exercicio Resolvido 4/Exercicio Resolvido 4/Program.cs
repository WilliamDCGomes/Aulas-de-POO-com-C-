using Exercicio_Resolvido_4.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Authentication;

namespace Exercicio_Resolvido_4 {
    class Program {
        static void Main(string[] args) {
            List<Employes> list = new List<Employes>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    list.Add(new Employes(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employes emp in list) {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
