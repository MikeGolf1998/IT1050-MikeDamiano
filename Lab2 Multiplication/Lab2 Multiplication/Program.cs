using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String A;
            string B;
            int a;
            int b;

            Console.WriteLine("Enter the First Number to Calculate");
            A = Console.ReadLine();
            a = Convert.ToInt32(A);
            Console.WriteLine("Enter the Second Number to Calculate");
            B = Console.ReadLine();
            b = Convert.ToInt32(B);

            Console.WriteLine(a + "x" + b + "=" + b * a);
            Console.ReadLine();
        }
    }
}
