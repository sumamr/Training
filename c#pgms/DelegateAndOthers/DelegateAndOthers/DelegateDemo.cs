using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndOthers
{
    public delegate int Calculate(int n1,int n2);
  //  public delegate int display();
    internal class Calculator
    {
        public static  int Add(int n1,int n2)
        {
            Console.WriteLine(n1 + n2);
            return 0;
        }
        public static int Subtract(int n1,int n2)
        {
             
            
            //Console.WriteLine(n1 - n2);
            return n1-n2;
        }
        public int Multiply(int n1,int n2)
        {
            return (n1 * n2);
           // return mul;
        }
        public int Division(int n1,int n2)
        {
            return n1 / n2;
            //Console.WriteLine(d);
        }
        public void show()
        {
            Console.WriteLine(show);
        }
            

    }
    internal class DelegateDemo
    {
        public static void DemoDelagate()
        {
            int result = 0;
            result = Calculator.Add(10, 20);
            Console.WriteLine("Regular Method call :result of Addition is "+result);


            Calculate cal=new Calculate(Calculator.Add);
            result= cal.Invoke(100, 1000);
            Console.WriteLine("Delegate Method call For Addition : " + result);


            cal=new Calculate(Calculator.Subtract);
            result=cal.Invoke(100, 10);
            Console.WriteLine("Delegate Method call For Subtraction : " + result);


            Calculator cal1=new Calculator();
            cal = cal1.Multiply;
            result = cal.Invoke(100, 10);
            Console.WriteLine("Delegate  Multiply method call for non static  : " + result);

            cal = cal1.Division;
            result=cal.Invoke(100, 10);
            Console.WriteLine("Delegate Division method for non static : " + result);

            //Multiple delegate
            Calculate cal2 = new Calculate(Calculator.Add);
            cal2 += Calculator.Subtract;
            int answer = cal2(12, 1);
            Console.WriteLine("Multiple Delegate : "+answer);




        }
    }
}
