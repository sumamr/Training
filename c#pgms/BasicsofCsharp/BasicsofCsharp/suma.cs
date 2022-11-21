using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{ 
    
    internal class suma
    {
        public int code { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public int gold { get; set; }

        public int silver { get; set; }
        public int bronze { get; set; }
        public int total { get; set; }

        public suma(int code, string name, int year, int gold, int silver, int bronze, int total)
        {
            this.code = code;
            this.name = name;
            this.year = year;
            this.gold = gold;
            this.silver = silver;
            this.bronze = bronze;
            this.total = total;
        }
        public string info()
        {
            return $"Code : {this.code} Name : {this.name} Gold : {this.gold} Silver : {this.silver} Bronze : {this:bronze} Total : {this.total}";
        }
        public static void List()
        {
            var sumaList = new List<suma>();
            
               sumaList.Add(new suma(1,"Australia",2022,67,57,54,90));
            sumaList.Add(new suma(2, "Newyork", 2022, 67, 57, 54, 90));
            sumaList.Add(new suma(3, "India", 2022, 67, 57, 54, 90));
            sumaList.Add(new suma(4, "Canada", 2022, 67, 57, 54, 90));
            sumaList.Add(new suma(5, "England", 2022, 67, 57, 54, 90));

            foreach(var s in sumaList)
            {
                Console.WriteLine(s.info());
            }
            int grandtotal = 0;
            foreach(var s in sumaList)
            {
                grandtotal=grandtotal+s.total;
            }
            Console.WriteLine("Total medals of all Countries is "+grandtotal);

            Console.WriteLine("*****Changing Medals of India*********");
            foreach(var s in sumaList)
            {
                if(s.name.Equals("India"))
                {
                    s.gold += 2;
                    s.total += 2;
                    break;

                }
               // Console.Write(s.gold);
            }
            foreach(var s in sumaList)
            {
                Console.WriteLine(s.info());
            }

            Console.WriteLine("*****Removing The Country India*********");
            int id = -1;
            foreach(var s in sumaList)
            {
                if(s.name.Equals("India"))
                {
                    //Console.WriteLine(s.info());
                    id = sumaList.IndexOf(s);
                    break;
                }
               
                

            }
            sumaList.RemoveAt(id);
            foreach(var s in sumaList)
            {
                Console.WriteLine(s.info());
            }

        }
       


    }
    
}
    