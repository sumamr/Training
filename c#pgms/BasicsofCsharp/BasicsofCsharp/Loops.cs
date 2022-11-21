using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Loops
    {
        public static void WhileLoop()
        {
            int a = 20;
            int b = 40;
            while(a<=b)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
        }
        public static void forLoop()
        {
            Console.WriteLine("*******************");
            int n1 = 10;
            //int n2 = 20;
            for(int i = 0; i < n1; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ifWithBreak()
        {
            Console.WriteLine("************");
            int a = 2;
            int b = 20;
            for(int i=a; i <=b; i+=2)
            {
                
                if (i == 18)
                break;
                Console.WriteLine(i);
            }

        }
        public static void ifWithContinue()
        {
            
            int start = 5;
            int end = 50;
            Console.WriteLine("break upto 10");
            for(int i=start; i <=end; i=i+5)
            {
                if (i == 30)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Continuing without printing 35");
            for (int i=start; i<=end; i=i+5)
            {
                if (i== 25)
                    continue;
                Console.WriteLine(i);
            }
            

        }
            

            

    }
}
