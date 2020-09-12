using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to add");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Integers intobj1 = new Integers();
            int result1 = intobj1.myMethod(num1);
            Console.WriteLine(result1);
            
            Console.WriteLine("Pick a number to mulitply");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result2 = intobj1.myMethod2(num2);
            Console.WriteLine(result2);

            Console.WriteLine("Pick a number to divide");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result3 = intobj1.myMethod3(num3);
            Console.WriteLine(result3);
            Console.ReadLine();


        }
    }
}
