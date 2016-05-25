using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    class MyMath
    {
        public long Factorial(int n)
        {
            return n < 1 ? 1 : n * Factorial(n - 1);
        }

        public long Power(int a, int b)
        {
            long pow = 1;
            for (int i = 0; i < b; i++)
                pow *= a;
            return pow;
        }     
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            int n = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myMath.Factorial(n));
            Console.WriteLine(myMath.Power(a, b));
        }
    }
}
