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
            Console.Write("enter a number : "); int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the result : " + operation.Factorial(number));
            Console.ReadLine();
        }
    }

    public class Operation
    {
        public int Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            return Factorial(number - 1) * number;
        }
    }
}
