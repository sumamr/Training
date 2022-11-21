using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class CoronaTest
    {
       
            public static void testMethod()
            {

                CoronaDashboard corona = new CoronaDashboard();
                Console.WriteLine("Corona Data");
                Corona s1 = new Corona(1,"Maharashtra",500,0,6,100);
                corona.addCoronaData(s1);
                Corona s2 = new Corona(2, "Kerala", 1000, 70, 10, 2000);
                corona.addCoronaData(s2);
                Corona s3=new Corona(3, "Karnataka", 500, 0, 6, 506);
                corona.addCoronaData(s3);
                Corona s4 = new Corona(4, "Tamil Nadu", 4420, 1000, 6, 3000);
                corona.addCoronaData(s4);
                Corona s5 = new Corona(5, "Andhra Pradesh", 1000, 1076, 6, 900);
                corona.addCoronaData(s5);
                corona.listCoronaData();

            Corona s6 = new Corona(6, "Jharkhand", 1000, 500, 500, 2000);
            corona.updateCoronaData(s6);
            Console.WriteLine("UPdating the corona data");
            corona.listCoronaData();
            //corona.info();
            Corona d = new Corona(6, "Karnataka", 500, 0, 6, 506);
            corona.deleteCoronaData(d);
            // corona.listCoronaData();

            corona.displayTopState();

            }

        
    }
}
