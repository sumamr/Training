using AssemblyTest;
using CalculatorLib;

internal class Program
{
    private static void Main(string[] args)
    {
        //Calculator
        /* Console.WriteLine("Hello, World!");
         Class1 calc = new Class1();
         int res1 = calc.add(34, 90);
         Console.WriteLine("Addition is "+res1);
         int  res2 = calc.mul(1, 2);
         Console.WriteLine("Multiplication is "+res2);
         int res3 = calc.subtract(5, 2);
         Console.WriteLine("Subtraction  is "+res3);*/


        //Electricity Bill
         ElectricityBill bill = new ElectricityBill();
         Console.WriteLine("*****Enter Units*****");
         var units = Convert.ToInt32(Console.ReadLine());
         var show=bill.calculateBill(units);
         Console.WriteLine($"Amount is {units} is : {show}Rs/-");
         Ref r = new Ref();
         r.Refdemo();
         

        //Corona
       // CoronaTest1.testMethod();
        //Student Reflection
    // ReflectionDemo dem=new ReflectionDemo();
      //  dem.demref();
        

    }
}