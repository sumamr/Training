using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    internal class coronadashboard
    {
        public List<corona> suma=new List<corona>();
        public void  addCoronaData(corona corona)
        {
            suma.Add(corona);
        }
        public void UPdateCoronaData(corona corona)
        {
            Console.WriteLine("updating corona data of "+corona.name);
            foreach(var s in suma)
            {
                if(s.code==corona.code)
                {
                    suma[suma.IndexOf(s)] = corona;
                    break;
                }
            }
            foreach (var s in suma)
                Console.WriteLine(s.info());
        }
        public void DeleteCoronaData(corona corona)
        {
            int del = -1;
            foreach(var s in suma)
            {
                if(s.name.Equals(corona.name))
                {
                    del = suma.IndexOf(s);
                    break;
                }
                suma.RemoveAt(del);
            }
        }
        public void  CoronaInfo()
        {
            foreach(var s in suma )
            {
                Console.WriteLine(s.info());
            }
        }


    }
}
