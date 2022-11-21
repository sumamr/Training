using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Oops
    {
        public int code;
        public string name;
        public string desc;
        public string supplier;
        public float price;

        public string info()
        {
            return " Code : " +code+  "\n Name : "+name+ "\n Description : "+desc+ "\n Supplier : "+supplier+ "\n Price : "+price;

        }

    }
}
