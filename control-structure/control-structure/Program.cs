using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_structure {
    class Program {
        static void Main(string[] args) {

            /* if-else structure

            int hour;

            Console.Write("Enter an hour of the day: ");
            hour = int.Parse(Console.ReadLine());

            if (hour < 12) {
                Console.WriteLine("Good morning!");
            } else {
                Console.WriteLine("Good afternoon");
            }
            */


            /*
            int x, sum;

            sum = 0;
            Console.Write("Enter the first number: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                sum = sum + x;
                Console.Write("Enter another number: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("SUM = " + sum);
            */

            int N, i, x, sum;

            Console.Write("How many numbers will be entered? ");
            N = int.Parse(Console.ReadLine());

            sum = 0;
            for (i = 1; i <= N; i++) {
                Console.Write("Enter a number: ");
                x = int.Parse(Console.ReadLine());
                sum = sum + x;
            }

            Console.WriteLine("SUM = " + sum);
        }
    }
}
