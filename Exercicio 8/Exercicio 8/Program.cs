using System;
namespace Exercicio_8 {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int manyRooms = int.Parse(Console.ReadLine());
            Cadastro[] c = new Cadastro[manyRooms];
            for(int i = 0; i < manyRooms; i++) {
                Console.WriteLine("Rent #"+(i+1));
                Console.Write("Name: ");
                string nameClient = Console.ReadLine();
                Console.Write("Email: ");
                string emailClient = Console.ReadLine();
                Console.Write("Room: ");
               int roomClient = int.Parse(Console.ReadLine());
                c[i] = new Cadastro { NameClient = nameClient, EmailClient = emailClient, RoomClient = roomClient };
                Console.WriteLine("\n");
            }
            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < 10; i++) {
                for(int x = 0; x < manyRooms; x++) {
                    if(c[x].RoomClient == i) {
                        Console.WriteLine(i + ": " + c[x].NameClient + ", " + c[x].EmailClient);
                        break;
                    }
                }
            }
        }
    }
}
