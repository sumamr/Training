using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class ElectricityBill
    {
    public double calculateBill(int units)
        {
            
            int amt;

            if (units <= 100)

                amt = units * 1;
            else if ((units > 100) && (units <= 200))

                amt = (100 * 1) + (units - 100) * 2;

            else if ((units > 200) && (units <= 300))

                amt = (100 * 1) + (100 * 2) + ((units - 200) * 3);

            else

                amt = (100 * 1) + (100 * 2) + (100 * 3) + (units - 300) * 5;

            return amt;
        }
    }
    public class Ref
    {


        public void Refdemo()
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (var s in types)
            {
                Console.WriteLine("Class : {0} ", s.Name);
                MethodInfo[] methods = s.GetMethods();
                foreach (var m in methods)
                {
                    Console.WriteLine("-->Methods : {0} ", m.Name);
                    ParameterInfo[] parameters = m.GetParameters();
                    foreach (var p in parameters)
                    {
                        Console.WriteLine("-->Parameters : {0}Type : {1}", p.Name, p.ParameterType);
                    }
                }
            }
        }

    }
}

