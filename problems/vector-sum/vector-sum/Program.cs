using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector_sum {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            double sum, average;

            Console.Write("How many numbers will you type? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++) {
                Console.Write("Enter a number: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.Write("VALUES = ");
            for (int i = 0; i < N; i++) {
                Console.Write(vet[i].ToString("F1", CI) + " ");     
            }

            Console.WriteLine();

            sum = 0;
            Console.Write("SUM = ");
            for (int i = 0; i < N; i++) {
                sum = sum + vet[i]; 
            }
            Console.Write(sum.ToString("F2", CI));
            Console.WriteLine();

            average = sum / N;
            Console.WriteLine("AVERAGE = " + average.ToString("F2", CI));
        }
    }
}
