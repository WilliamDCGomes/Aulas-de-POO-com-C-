using System;
namespace Exercício_10 {
    class Program {
        static void Main(string[] args) {
            string[] dimension = Console.ReadLine().Split();
            int m = int.Parse(dimension[0]);
            int n = int.Parse(dimension[1]);
            int[,] matr = new int[m, n];
            for(int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split();
                for(int j = 0;j < n; j++){
                    matr[i, j] = int.Parse(values[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if(matr[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: " + matr[i,j-1]);
                        }
                        if (j + 1 <= n - 1) {
                            Console.WriteLine("Right: " + matr[i,j+1]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Up: " + matr[i - 1, j]);
                        }
                        if (i + 1 <= m - 1) {
                            Console.WriteLine("Down: " + matr[i+1,j]);
                        }
                    }
                }
            }
        }
    }
}
