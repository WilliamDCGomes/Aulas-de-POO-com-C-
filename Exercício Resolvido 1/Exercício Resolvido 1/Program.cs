using System;
namespace Exercício_Resolvido_1 {
    class Program {
        static void Main(string[] args) {
            int quant = int.Parse(Console.ReadLine());
            int[,] matr = new int[quant, quant];
            int negativeNumber = 0;
            int[] diagonalMain = new int[quant];
            int aux = 0;
            for (int i = 0; i < quant; i++) {
                string[] vet = Console.ReadLine().Split();
                for (int j = 0; j < quant; j++) {
                    matr[i, j] = int.Parse(vet[j]);
                    if (matr[i, j] < 0) {
                        negativeNumber++;
                    }
                    if (i == j) {
                        diagonalMain[aux] = matr[i, j];
                        aux++;
                    }
                }
            }
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < quant; i++) {
                if (i == quant - 1) {
                    Console.WriteLine(diagonalMain[i]);
                }
                else {
                    Console.Write(diagonalMain[i] + " ");
                }
            }
            Console.WriteLine("Negative numbers = " + negativeNumber);
        }
    }
}
