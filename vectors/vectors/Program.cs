using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectors {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, i;
            Console.Write("how many numbers you will enter? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i = 0; i < N; i++) {
                Console.Write("Enter a number: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.WriteLine("TYPED NUMBERS:");
            for (i = 0; i < N; i++) {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        }
    }
}
