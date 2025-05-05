using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_output {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int age;
            double salary;
            string name;
            char sex;

            age = 32;
            salary = 4560.9;
            name = "Maria Silva";
            sex = 'F';

            Console.WriteLine(name + ", sex " + sex + ", wins " + salary.ToString("F2", CI) + " and is " + age +  " years old");
        }
    }
}
