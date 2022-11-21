using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicsofCsharp.ExceptionDemo;

namespace BasicsofCsharp
{
    internal class ThrowDemo
    {
        
        public class Students
        {
            public string StudentName { get; set; }
        }
        public static void demostd1(Students std)
        {
            if(std == null)
            {
                throw new NullReferenceException("Student Object is Null");
               
            }
            Console.WriteLine(std.StudentName);
        }
        public static void method()
        {
            Students std = null;

            try
            {
                demostd1(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        
        public static void demostd2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }

        public static void Method2()
        {
            string str = null;
            try
            {
                Console.Write(str[0]);
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }

        public static void demostd3()
        {
            try
            {
                Methods1();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        public static void Methods1()
        {
            try
            {
                Methods2();
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        public static void Methods2()
        {
            string str = null;
            try
            {
                Console.Write(str[0]);
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }
    }
    }
        
    

