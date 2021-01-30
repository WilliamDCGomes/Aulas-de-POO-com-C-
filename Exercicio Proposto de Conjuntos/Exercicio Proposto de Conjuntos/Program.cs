using System;
using System.Collections.Generic;

namespace Exercicio_Proposto_de_Conjuntos {
    class Program {
        static void Main(string[] args) {
            HashSet<int> TotalStudents = new HashSet<int>();
            int total = 0;
            Console.Write("How many students for course A? ");
            int quantityCourseA = int.Parse(Console.ReadLine());
            for(int i =0; i< quantityCourseA; i++) {
                int student = int.Parse(Console.ReadLine());
                TotalStudents.Add(student);
            }
            Console.Write("How many students for course B? ");
            int quantityCourseB = int.Parse(Console.ReadLine());
            for(int i =0; i< quantityCourseB; i++) {
                int student = int.Parse(Console.ReadLine());
                TotalStudents.Add(student);
            }
            Console.Write("How many students for course C? ");
            int quantityCourseC = int.Parse(Console.ReadLine());
            for(int i =0; i< quantityCourseC; i++) {
                int student = int.Parse(Console.ReadLine());
                TotalStudents.Add(student);
            }
            foreach(int student in TotalStudents) {
                total++;
            }
            Console.WriteLine($"Total students: {total}");
        }
    }
}
