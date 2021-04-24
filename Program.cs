using System;

namespace fibonacci
{
    class Program
    {
        public static void Fibonacci(int x)
        {
            var previousValue = -1;
            var currentResult = 1;

            for (var i = 0; i < x; ++i)
            {
                var sum = currentResult + previousValue;
                previousValue = currentResult;
                currentResult = sum;
                Console.Write("{0} ", currentResult);
            }
        }
        static void Main(string[] args)
        {
            Console.Write(" Input number for the Fibonacci series : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n The Fibonacci series of {0} terms is : ",n1);
	        Fibonacci(n1);
        }
    }
}
