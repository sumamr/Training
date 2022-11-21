using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Arrays
    {
        public static void arrays()
        {
            string[] flowers = { "Sunflower", "Marigold", "Lilly", "Rose", "Champa" };
            Console.WriteLine(flowers);
            for(int i = 0; i < flowers.Length; i++)
            {
                Console.WriteLine(flowers[i]);
            }
            Console.WriteLine("************************");
            Console.WriteLine("update");
            Console.WriteLine("***************");
            flowers[0] = "Jasmin";

            foreach(string s in flowers)
            {
                Console.WriteLine(s);
            }

            
            Console.WriteLine("****************");
            Console.WriteLine("Creating New Arry");

            

            int[] suma = new int[4];
            suma[0] = 23;
            suma[1] = 45;
            suma[2] = 67;
            suma[3] = 12;
            foreach(int i in suma)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************");
            int max = suma.Max();
            Console.WriteLine("Maximum of given array is "+max);

            Console.WriteLine("***********************");
            int min = suma.Min();
            Console.WriteLine("Minimum of given array is " + min);

            Console.WriteLine("***********************");
            int sum = suma.Sum();
            Console.WriteLine("Sum of given array is " + sum);



        }
    }
}
