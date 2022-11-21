using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DelegateAndOthers.EmployeeSeparator;

namespace DelegateAndOthers
{
     class EmployeeSeparator
    {
        public delegate void EmployeeSeparatedEventHandler();
        public event EmployeeSeparatedEventHandler EmployeeSeparated;
        public void Separate()
        {
            if(EmployeeSeparated != null)
            {
                EmployeeSeparated();
            }
        }
    }
    internal class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;
        public Finance(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;

        }
        public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("Finance Department : employee separation");
        }
    }
    internal class HR
    {
        private readonly EmployeeSeparator employeeSeparator;
        public  HR(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator= employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }
        public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("HR Department : employee separation");
        }

    }
    internal class EventDemo
    {
        internal static void testEvent()
        {
            EmployeeSeparator employeeSeparator = new EmployeeSeparator();
            Finance finance = new Finance(employeeSeparator);
           // employeeSeparator.Separate();
            HR hR = new HR(employeeSeparator);
            employeeSeparator.Separate();
        }
    }
}
