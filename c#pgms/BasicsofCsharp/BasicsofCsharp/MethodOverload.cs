using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class MethodOverload
    {
        public int  add(int n1,int n2)
        {
            int s = n1 + n2;
            //  Console.WriteLine("Addition of Two Integer value is "+s);
            return s;
        }
        public float add(float n1,float n2)
        {
            float s1 = n1 + n2;
          //  Console.WriteLine("Addition of Two float values is " + s);
          return (float)s1;
        }
        public float add(int n1,float n2)
        {
            float s2= n1 + n2;
            //  Console.WriteLine("Addition of float and int value is " + s);
            return s2;
        }
    }
}
