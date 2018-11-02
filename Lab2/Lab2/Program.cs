using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class multiplication
    {
        private static int product;

        public static void Main(string[] args)
        {
            int number1; //declare first number to multiply
            int number2; //declare second number to multiply
            int sum; // declare product

            Console.Write("Enter first integer: "); //prompt user
                                                    //Read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); //prompt user
                                                     //Read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2; //multiply numbers

            Console.WriteLine("Product is {0}", product); //display product
            Console.ReadLine();
            //
        }
    }
}
