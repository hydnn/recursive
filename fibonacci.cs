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
            int number= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(operation.Fibonacci(i));
            }
            Console.ReadLine();
        }
    }
    public class Operation
    {
        public int Fibonacci(int number)
        {
            if (number == 1 || number == 0)
                return 1;

            return Fibonacci(number-1)+Fibonacci(number-2);
        }
    }
}
