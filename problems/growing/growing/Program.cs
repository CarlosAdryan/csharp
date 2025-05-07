using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace growing {
    class Program {
        static void Main(string[] args) {

            int x, y;

            Console.WriteLine("Enter two numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if (x > y) {
                    Console.WriteLine("DECREASING! ");
                }
                else {
                    Console.WriteLine("GROWING! ");
                }
                Console.WriteLine("Enter two other numbers");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
