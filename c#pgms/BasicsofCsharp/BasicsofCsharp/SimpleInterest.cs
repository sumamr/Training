using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class SimpleInterest
    {
        public static void simpleInterest()
        {
            Console.WriteLine("Calculating Simple Interest");
            Console.WriteLine("Enter the Principle Amount");
            int amt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate Of Interest");
            int r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time");
            float time=Convert.ToInt32(Console.ReadLine());
            float si;
             si = (amt * r * time) / 100;
            Console.WriteLine("Simple Interest for amt " + amt + " at the rate " + r + " is " +si);


        }
    }
}
