using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTest
{
    public class ReflectionDemo
    {
        class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public Student()
            {
                RollNo = 0;
                Name = string.Empty;
            }
            public Student(int rno, string n)
            {
                RollNo = rno;
                Name = n;
            }
            public void displayData()
            {
                Console.WriteLine("Roll Number : {0}", RollNo);
                Console.WriteLine("Name : {0}", Name);
            }
        }
        

        public void demref()
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (var s in types)
            {
                Console.WriteLine("Class : {0}", s.Name);

                MethodInfo[] methods = s.GetMethods();
                foreach (var m in methods)
                {
                    Console.WriteLine("-->Methods : {0}", m.Name);

                    ParameterInfo[] parameters = m.GetParameters();
                    foreach (var p in parameters)
                    {
                        Console.WriteLine("Parameters : {0} Type : {1} ", p.Name, p.ParameterType);
                    }
                }

            }

        }
    }
}
    

