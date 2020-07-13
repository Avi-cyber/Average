using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double Result;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());

            Result =(double) (a + b + c) / 3;
            Console.WriteLine(Result);
        }
    }
}
