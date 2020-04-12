using System;
using System.Collections.Generic;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            list.Add("Fabio");
            list.Add("Jhonny");
            list.Add("William");
            list.Add("Karla");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Tamanho da lista: " + list.Count + "elementos");
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First name with A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last name with A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do primeiro que começa com a letra A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do último que começa com a letra A: " + pos2);
            Console.WriteLine("-------------------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------------");
            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------------");
            list.RemoveAt(0);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------------");
            list.RemoveRange(2, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
