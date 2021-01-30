using System;
using System.Collections.Generic;
using System.IO;
using Exercicio_Resolvido_de_Conjuntos.Entities;

namespace Exercicio_Resolvido_de_Conjuntos {
    class Program {
        static void Main(string[] args) {
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            List<LogRecord > people = new List<LogRecord>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        LogRecord person = new LogRecord { Username = name, Instant = instant };
                        bool aux = set.Add(person);
                        if (aux) {
                            people.Add(person);
                        } else {
                            foreach(LogRecord i in people) {
                                if (i.Username.Equals(person.Username)) {
                                    i.Increment();
                                    break;
                                }
                            }
                        }
                    }
                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
            foreach (LogRecord i in people) {
                Console.WriteLine(i.Username + ": " + i.quantity);
            }
        }
    }
}
