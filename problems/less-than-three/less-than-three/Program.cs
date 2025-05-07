using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_than_three {
    class Program {
        static void Main(string[] args) {

            int a, b, c; 

            Console.Write("First value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Second value: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("third value: ");
            c = int.Parse(Console.ReadLine());

            if (a < c && a < b) {
                Console.WriteLine("MINOR = " + a);
            } else if (b < c){
                Console.WriteLine("MINOR = " + b);
            } else {
                Console.WriteLine("MINOR = " + c);
            }
        }
    }
}
