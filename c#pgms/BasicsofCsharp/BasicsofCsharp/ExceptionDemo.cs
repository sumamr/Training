using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class ExceptionDemo
    {
        public class Student
        {

            public string StudentName { get; set; }
        }
        public static void demo1()
        {
            try
            {
                Console.WriteLine("Enter Number to find Square Root");
                var num=int.Parse(Console.ReadLine());
                Console.WriteLine("Square of {0} is : {1} ",num, num * num);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            finally
            {
                Console.WriteLine("Try with  Numbers ");
            }
        }

        public static void demo2()
        {
            Console.WriteLine("******All types of Exceptions**********");
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred! Please try again.");
            }
        }
        public static void demo3()
        {
            Console.WriteLine("****Multiple Try Catch******");
            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }
        public static void demo4()
        {
            Console.WriteLine("******Outer Multiple Try Block**************");
            Student std = null;

            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }
        public static void demo5()
        {
            Console.WriteLine("*********Finally Block**********");
            FileInfo file = null;

            try
            {
                Console.Write("Enter a file name to write: ");
                string fileName = Console.ReadLine();
                file = new FileInfo(fileName);
                //file.AppendText("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: {0}", ex.Message);
            }
            finally
            {
                // clean up file object here;
                file = null;
            }
        }
    }
}
