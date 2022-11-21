using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndOthers
{
    public delegate void AnonymousDelegate(int n1);
    public delegate int MyDelegate(int n1, int n2);
    public delegate int MathsDelegate(int num);
    internal class AnonymousNLambda

    {
        internal static void AnonymousDemo()
        {
            AnonymousDelegate amd = delegate (int a)
            {
                a += 11;
                Console.WriteLine("Anonymous Function "+a);

            };
            amd(10);
           
            
            MyDelegate obj = (a, b) => a + b;
            int sum = obj.Invoke(100, 200);
            Console.WriteLine("Anonymous:Lambda:Sum is "+sum);

            MathsDelegate mdCUBE = (num) => num * num * num;
            int cube = mdCUBE(2);
            Console.WriteLine("CUBE of {0} is {1}",2,cube);

            MathsDelegate mdSQR=(num) => num * num * num;   
            int sqr=mdSQR(6);
            Console.WriteLine("SQUARE of {0} is {1}",6,sqr);


            Console.WriteLine("Delegate as parameters");
            DelegateASParam(delegate (int a)
            {
                a += 10;
                Console.WriteLine("delegate " + a);
                return a;
            }, 5);


        }
        internal static void DelegateASParam(MathsDelegate mathDel,int num)
        {
            num += 10;
            mathDel(num);
        }
    }
}
