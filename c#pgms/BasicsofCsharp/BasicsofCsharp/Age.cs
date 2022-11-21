using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Age
    {
        public static void VoteEligible()
        {
            Console.WriteLine("********************");
            Console.WriteLine("Enter Your Name:");
            //String name=Console.ReadLine();
            //Console.WriteLine("Your name is "+ name);
            Console.WriteLine("Enter Your Age");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is "+age);
            if(age<18)
            {
                Console.WriteLine("Not Eligible for voting");
            }
            else
            {
                Console.WriteLine("Eligible for voting");
            }

        }

    }
}
