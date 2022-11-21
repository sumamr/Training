using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Currency
    {
        public static void cur()
        {
            Console.WriteLine("Enter the Currency in USD Format");
            int usd=Convert.ToInt32(Console.ReadLine());
            float i, inr,i1;
            i= 79.77f;
            inr = usd * i;
            Console.WriteLine("Conversion from USD to INR is "+inr);
        }
        public static void cur1()
        {
            Console.WriteLine("Enter the Currency in EURO Format");
            int euro = Convert.ToInt32(Console.ReadLine());
            float i, inr;
            i = 79.24f;
            inr= euro * i;
            Console.WriteLine("Conversion from EURO to INR is " + inr);
        }

    }
    }

