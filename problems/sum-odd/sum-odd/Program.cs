using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_odd {
    class Program {
        static void Main(string[] args) {

            int x, y, sum, exchange;

            Console.WriteLine("Enter two numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                exchange = x;
                x = y;
                y = exchange;
            }

            sum = 0;
            for (int i = x+1; i < y; i++) {
                if (i % 2 != 0) {
                    sum = sum + i;
                }
            }
            Console.WriteLine("SUM OF THE ODD = " + sum);
        }
    }
}
