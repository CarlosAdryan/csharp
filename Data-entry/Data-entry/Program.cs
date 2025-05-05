using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_entry {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double salary1, salary2;
            string name1, name2;
            int age;
            char sex;

            Console.Write("Enter the name of the first person: ");
            name1 = Console.ReadLine();
            Console.Write("Enter the salary of the first person: ");
            salary1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Enter the name of the second person: ");
            name2 = Console.ReadLine();
            Console.Write("Enter the salary of the second person: ");
            salary2 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Enter an age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Type a sex (F/M): ");
            sex = char.Parse(Console.ReadLine());

            Console.WriteLine("NAME 1 = " + name1);
            Console.WriteLine("SALARY 1 = " + salary1.ToString("F2", CI));
            Console.WriteLine("NAME 2 = " + name2);
            Console.WriteLine("SALARY 2 = " + salary2.ToString("F2", CI));
            Console.WriteLine("AGE = " + age);
            Console.WriteLine("SEX = " + sex);

        }
    }
}
