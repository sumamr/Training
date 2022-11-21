using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Conversion
    {
        public static void milesTokilo()
        {
            Console.WriteLine("Conversion from miles to kilometer");
            Console.WriteLine("Enter the Distance in miles");
            int m=Convert.ToInt32(Console.ReadLine());
            float k,km;
            km = 1.06f;
            k = m*km ;
            Console.WriteLine("Miles in kilometer is " + k);
        }
    }
}
