using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class PrintingTable
    {
        public static void Table()
        {
            Console.WriteLine("Enter Table");
            int table=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(table*i);
            }
        }
    }
}
