using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices {
    class Program {
        static void Main(string[] args) {

            int M, N, i, j;

            Console.Write("How many lines will the matrix have? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("How many columns will the matrix have? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("TYPED MATRIX");
            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
