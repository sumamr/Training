using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class CoronaTest1
    {
        public static void testMethod()
        {
            coronadashboard cor = new coronadashboard();
            Console.WriteLine("Corona Data");
            corona s1 = new corona(1, "Jharkhand", 20, 30, 40, 80);
            cor.addCoronaData(s1);
            corona s2 = new corona(2, "maharashtra", 34, 50, 70, 10);
            cor.addCoronaData(s2);
            cor.CoronaInfo();
            Console.WriteLine("******Updating Corona Data**********");
            corona up=new corona(1, "Jharkhand", 20, 30, 40, 80);
            up.death -= 1;up.total-= 1;
            cor.UPdateCoronaData(up);
            cor.CoronaInfo();
            corona d= new corona(2, "maharashtra", 34, 50, 70, 10);

             cor.DeleteCoronaData(d);
           // cor.CoronaInfo();

        }
    }
}
