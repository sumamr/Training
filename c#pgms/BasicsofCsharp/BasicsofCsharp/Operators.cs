using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    public static class Operators
    {
        
        public static void arithmeticOperator()
        {
            Console.WriteLine("Arithmetic Operations");
            Console.WriteLine("********************");
            int n1 = 12;
            int n2 = 13;
            int sum=n1 + n2;
            int sub = n1 - n2;
            int mul=n1 * n2;
            Console.WriteLine("sum is "+sum) ;
            Console.WriteLine("Subtraction is " + sub);
            Console.WriteLine("Multiplication is " + mul);
            Console.WriteLine("********************");
            Console.WriteLine("Relational Operations");
            Console.WriteLine("********************");

        }
        public static void relationalOp()
        {
            int a = 45;
            int b = 12;
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        }
        

    }
}
