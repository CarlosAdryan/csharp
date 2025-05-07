using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ages {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string name1, name2;
            int age1, age2;
            double average;

            Console.WriteLine("First person data: ");
            Console.Write("Name: ");
            name1 = (Console.ReadLine());
            Console.Write("Age: ");
            age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second person data: ");
            Console.Write("Name: ");
            name2 = (Console.ReadLine());
            Console.Write("Age: ");
            age2 = int.Parse(Console.ReadLine());

            average = (double)(age1 + age2) / 2;
            
            Console.WriteLine("The average age of " 
                + name1 + " and " + name2 + " is " 
                + average.ToString("F1",CI) + " years");
        }
    }
}
