using System;
using System.IO;
using System.Globalization;
namespace Exercicio_15 {
    class Program {
        static void Main(string[] args) {
            string origin = @"c:\temp\input.csv";
            string destiny = @"c:\temp\out";
            try {
                Directory.CreateDirectory(destiny);
                string[] input = File.ReadAllLines(origin);
                using(StreamWriter sw = File.AppendText(destiny + @"\summary.csv")) {
                    foreach(string lines in input) {
                        string[] output = lines.Split(",");
                        sw.WriteLine($"{output[0]}, {((double.Parse(output[1])/100)*int.Parse(output[2])).ToString("F2",CultureInfo.InvariantCulture)}");
                    }
                }
                Console.WriteLine("Arquivo criado com sucesso");
            }
            catch (IOException e) {
                Console.WriteLine("An error accurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}