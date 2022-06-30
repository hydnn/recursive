using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            Console.Write("enter a number : "); ; int number=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the exponent : "); ; int exponent =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the result : " + operation.Expo(number,exponent));
            Console.ReadLine();
        }
    }

    public class Operation
    {
        public int Expo(int number, int exp)
        {
            if (exp < 2)
            {
                return number;
            }
            return Expo(number, exp-1) * number;
        }
    }
}
