using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_9 {
    class Program {
        static void Main(string[] args) {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registeres? ");
            int times = int.Parse(Console.ReadLine());
            for(int i = 0; i < times; i++) {
                Console.WriteLine("Emplyoee #" + (i+1) + ":");
                Console.Write("Id: ");
                string id = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine();
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            string searchEmployee = Console.ReadLine();
            Employee s1 = list.Find(x => x.Id == searchEmployee);
            if (s1 == null) {
                Console.WriteLine("This id does not exist!");
            }
            else {
                Console.Write("Enter the percentage: ");
                s1.increaseSalary(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
