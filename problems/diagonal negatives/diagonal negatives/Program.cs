using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal_negatives {
    class Program {
        static void Main(string[] args) {

            int N, negatives;

            Console.Write("What's the order of the matrix? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL MAIN: ");
            for (int i = 0; i < N; i++) {
                if (i == i) {
                    Console.Write(mat[i, i] + " ");
                }
            }

            Console.WriteLine();

            negatives = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i,j] < 0) {
                        negatives = negatives + 1;
                    }
                }
            }
            Console.WriteLine("NEGATIVE AMOUNT = " + negatives);
        }
    }
}
