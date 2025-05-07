using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangular {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double b, h;


            Console.Write("Rectangle base: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("rectangular height: ");
            h = double.Parse(Console.ReadLine(), CI);

            double area = b * h;
            double perimeter = 2 * (b + h);
            double diagonal = Math.Sqrt(b * b + h * h);

            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETER = " + perimeter.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

        }
    }
}
