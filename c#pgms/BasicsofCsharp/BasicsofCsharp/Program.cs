using BasicsofCsharp;
using System.Data;
using System.Threading.Channels;

internal class Program
{
    public static void Main(string[] args)
    {
        CoronaTest.testMethod();
      //  Reflection.suma();

        // Console.WriteLine("Hello, World!");
        // add();
        // Operators.arithmeticOperator();
        // Operators.relationalOp();
        // Program op = new Program();
        //  op.Compare();
        // Console.WriteLine("Loops");
        // Loops.WhileLoop();
        // Loops.forLoop();
        //  Loops.ifWithBreak();
        // Loops.ifWithContinue();
        //Age.VoteEligible();
        //SimpleInterest.simpleInterest();
        // PrintingTable.Table();
        // Conversion.milesTokilo();
        // Currency.cur();
        // Currency.cur1();
        //  Arrays.arrays();
        /*
        Oops product = new Oops();
        product.code = 1;
        product.name = "Mobile";
        product.desc = "8 gb RAM Technocart";
        product.supplier = "Techno Comapny";
        product.price = 12000;

        String information = product.info();
        Console.WriteLine(information);
        */

        /* Console.WriteLine("Customer Details using Constructor");
         Constructor Customer1 = new Constructor(1,"Suma","suma@gmail.com","7204830895","Channapatna");
         Console.WriteLine(Customer1.info());
         Customer1.country = "India";
         Console.WriteLine("Country "+Customer1.country);
         Customer1.zipcode = 562160;
         Console.WriteLine("ZipCode "+Customer1.zipcode);
         Console.WriteLine("*************************");

         Constructor Customer2 = new Constructor(2, "Ilakkiya", "ili@gmail.com", "67991111", "Tamil Nadu");
         Console.WriteLine(Customer2.info());
         Customer2.country = "India";
         Console.WriteLine("Country "+Customer2.country);
         Customer2.zipcode = 567890;
         Console.WriteLine("ZipCode "+Customer2.zipcode);
 */


        //Customer
        /*  Car car1 = new Car();
          car1.name = "SUV";
          car1.model = "Creta";
          car1.make = "Hundai";
          car1.price = 1200000;
          car1.color = "red";
          car1.ac = "Kenstar";

          car1.start();
          car1.move();
          car1.info();
          car1.stop();

          Console.WriteLine(car1.info());
         // Console.WriteLine(car1.move());
        */


        //BANK
        /*
        Account ac1 = new Account(123123, "Suma", "suma@gmail.com", "7204830895", 2000f);
        Account ac2 = new Account(123125, "Yash", "yash@gmail.com", "72048895", 200f);
        Account ac3 = new Account(456125, "Ilikkya", "ili@gmail.com", "234895", 3000f);
        Console.WriteLine(ac1.info());
        Console.WriteLine(ac2.info());
        Console.WriteLine(ac3.info());
        //case 1
        Console.WriteLine("**************************");
      Console.WriteLine("Available balance is "+ac1.DepositAmt(123123, 2546f));
      Console.WriteLine(ac1.WithdrawAmt(123123, 2000f));
      // Console.WriteLine(ac1.bal());
      
        */

        //OVERLOADING 
        /*
        MethodOverload suma = new MethodOverload();
        int s1=suma.add(12, 34);
      Console.WriteLine("Addition of two integer values are "+s1);
        Console.WriteLine("Addition of Two Float Values are "+suma.add(12.0f, 6.4f));
        */
        /*  SBI sbi = new SBI();
          float rate = sbi.rateOfInterest();
          Console.WriteLine("Rate Of Interest for SBI is "+sbi.rateOfInterest());
        */

        //OVERRIDING
        /*
        RBI rbi= new RBI();
        float r=rbi.rateOfInterest();
        Console.WriteLine("Rate Of Interest for RBI Bank is "+rbi.rateOfInterest());

        rbi=new SBI();
        r=rbi.rateOfInterest();
        Console.WriteLine("Rate Of Interest for SBI Bank is "+r);

        rbi = new HDFC();
        r=rbi.rateOfInterest();
        Console.WriteLine("Rate of Interest for HDFC Bank is "+r);

        rbi=new Corporation();
        r=rbi.rateOfInterest();
        Console.WriteLine("Rate Of Interest for Corporation Bank is "+r);
        */

        //  INTERFACE
        /*
        IUniversalRemote inte=new SONYTV();
        inte.switchOn();
        inte.switchOff();
        inte.changeChannel("ZeeKannada");
        inte.changeVolume(20);
        */
        //  abstractDemo.testDemo();


        //ArrayList

        //Interface
        //  Interface1.testInterface();

        //ArrayList
        /*
        ArrayListDemo.demo1();
        ArrayListDemo.demo2();
        ArrayListDemo.demo3();
        ArrayListDemo.demo4();
        ArrayListDemo.demo5();
        ArrayListDemo.demo6();
        ArrayListDemo.demo7();
        ArrayListDemo.demo8();
*/

        //CWG
        //CWG.CWGDemo();
        //Exception Handling
        /*
       ExceptionDemo.demo1();
        ExceptionDemo.demo2();
        ExceptionDemo.demo3();
        ExceptionDemo.demo4();
       
        ExceptionDemo.demo5();
         */

      //  testCorona.testMethod();


        //Dictionary
        /*
         DictionaryDemo.demo1();
        Console.WriteLine(" ");
        DictionaryDemo.demo2();
        Console.WriteLine(" ");
        DictionaryDemo.demo3();
        Console.WriteLine(" ");
        DictionaryDemo.demo4();
        */

        //Throw
        /*
        
        demostd1 std = null;
        try
        {
            demostd1(std) 
        }
        catch
        {

        }
       


    }

*/
        //List
        /*
        List.demo1();
        List.demo2();
        List.demo3();
        List.demo4();
        List.demo5();
        List.demo6();
        List.demo7();
       */


        //BANK

        /*
        Accounts ac1 = new Accounts(123123, "Suma", "suma@gmail.com", "7204830895", 2000);
        Accounts ac2 = new Accounts(123125, "Yash", "yash@gmail.com", "72048895", 200);
        int option=10,acc;
        bool flag=false;
        Accounts[] ac = { ac1, ac2 };
        Console.WriteLine("Enter your Account Number");
        acc = Convert.ToInt32(Console.ReadLine());
        do
        {
            foreach(Accounts a in ac)
            {
                if (a.accountNumber == acc)
                {
                    flag = true;
                    Console.WriteLine("Select One Option");
                    Console.WriteLine("1.Deposit");
                    Console.WriteLine("2.Withdraw");
                    Console.WriteLine("3.CheckBalance");
                    Console.WriteLine("4.Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            a.DepositAmt();
              
                            break;
                        case 2:
                            a.WithdrawAmt(1200);
                               
                            break;
                        case 3:
                            a.CheckBalance(123123);
                            break;
                        //default:
                        //    Console.WriteLine("Invalid Input");
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Account does not exist.");
                    Console.WriteLine("Enter your Account Number");
                    acc = Convert.ToInt32(Console.ReadLine());
                }
            }
        } while (option != 4);

       */ 
      //  ThrowDemo.demostd1(null);
      // ThrowDemo.demostd2();
      //  ThrowDemo.demostd3();

     // suma.List();
        
        static void add()
        {
            int n1 = 10;
            float f2 = 10.00f;
            //long l3 = 10l;
            double d4 = 1000.00000;
            bool isActive = true;
            char chr = 'a';
            string suma = "c# programming";
            Console.WriteLine($"int value is: " + n1);
            Console.WriteLine($"Float value is: {f2}");
            // Console.WriteLine($"Long Value is: {l3}");
            Console.WriteLine($"Double value is: {d4}");
            Console.WriteLine($"Boolean value is: {isActive}");
            Console.WriteLine($"Char value is: {chr}");
            Console.WriteLine($"String value is: {suma}");
            Console.WriteLine($"******************");
            Console.WriteLine("Implicit Conversion");
            Console.WriteLine($"******************");
            Implicitconversion();



        }
        static void Implicitconversion()
        {
            int n1 = 10;
            double d1 = n1;
            Console.WriteLine($"int n1 {n1} : double d1 {d1}");
            float f1 = 45.90f;
            double d2 = f1;
            Console.WriteLine($"Float f1 {f1} : double d2 {d2} ");
            Console.WriteLine($"******************");
            Console.WriteLine("ExplicitConversion Conversion");
            Console.WriteLine($"******************");
            ExplicitConversion();

        }
        static void ExplicitConversion()
        {
            double d1 = 24.67;
            int n1 = (int)d1;
            Console.WriteLine($"double d1 {d1} : int n1 {n1}");
            Console.WriteLine($"******************");
        }
        /* public void Compare()
         {
             int a = 20;
             int b = 40;
             Console.WriteLine(a== b);
             Console.WriteLine("a is not equal to b");

         }
        */

    }
}
internal class demostd1
{
}