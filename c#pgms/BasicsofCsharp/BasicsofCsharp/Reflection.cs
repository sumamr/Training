using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Reflection
    {
        static void suma(string[] args)
        {
            Type t=typeof(string);

            Console.WriteLine("Name : {0}" ,t.Name);
            Console.WriteLine("Full Name :  {0}", t.FullName);
            Console.WriteLine("Name Space : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}",t.BaseType);

        }
    }
}
