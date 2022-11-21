using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProjects
{
    internal class demo1
    {
        public class Student
        {

            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

        }

        public static void demo()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            Console.WriteLine("**********LINQ query syntax C#**********");
            Console.WriteLine("Teen age Students:");

            foreach (Student std in teenAgerStudent)
            {
             
                Console.WriteLine(std.StudentName);
            }
        }
        public static void demo3()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // LINQ Query Method to find out teenager students
            var teenAgerStudent = studentList.Where(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine("*****Where in method*********");
            Console.WriteLine("Teen age Students:");

            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }
        }
        public static void demo4()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var filteredResult = studentList.Where((s, i) => {
                if (i % 2 == 0) // if it is even element
                    return true;

                return false;
            });

            Console.WriteLine("***********Where extension method in C#*********");
            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);
        }
        public static void demo5()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            var stdResult = from s in mixedList.OfType<Student>()
                            select s;
            Console.WriteLine("********OfType operator in C#*********");
            foreach (var str in stringResult)
               
                Console.WriteLine(str);

            foreach (var integer in intResult)
                Console.WriteLine(integer);

            foreach (var std in stdResult)
                Console.WriteLine(std.StudentName);

        }
        public static void demo6()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var orderByResult = from s in studentList
                                orderby s.StudentName //Sorts the studentList collection in ascending order
                                select s;

            var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                                          orderby s.StudentName descending
                                          select s;

            Console.WriteLine("Ascending Order:");

            Console.WriteLine("*******OrderBy Query in c#********");
            foreach (var std in orderByResult)
                Console.WriteLine(std.StudentName);

            Console.WriteLine("Descending Order:");

            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.StudentName);

        }
        public static void demo7()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);


            Console.WriteLine("*********OrderBy in Method**********");
            Console.WriteLine("Ascending Order:");
            foreach (var std in studentsInAscOrder)
                Console.WriteLine(std.StudentName);

            Console.WriteLine("Descending Order:");

            foreach (var std in studentsInDescOrder)
                Console.WriteLine(std.StudentName);

        }
        public static void demo8()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);

            Console.WriteLine("****OrderByDescending C#********");
            Console.WriteLine("Ascending Order:");

            foreach (var std in studentsInAscOrder)
                Console.WriteLine(std.StudentName);

            Console.WriteLine("Descending Order:");

            foreach (var std in studentsInDescOrder)
                Console.WriteLine(std.StudentName);

        }
        public static void demo9()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var multiSortingResult = from s in studentList
                                     orderby s.StudentName, s.Age
                                     select s;

            Console.WriteLine("*******Multiple sorting in Query syntax C#**********");
            foreach (var std in multiSortingResult)
                Console.WriteLine("Name: {0}, Age {1}", std.StudentName, std.Age);

        }
        public static void demo10()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            Console.WriteLine("ThenBy:");

            foreach (var std in thenByResult)
                Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

            Console.WriteLine("ThenByDescending:");

            foreach (var std in thenByDescResult)
                Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

        }



    }
}




