using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class CWG
    {

        public int code { get; set; }
        // int code;
        public string name{ get; set; }
        // string name;
        public int year { get; set; }
        // int year=2022;
        public int gold { get; set; }
        // int gold;
        public int silver { get; set; }
        // int silver;
        public int bronze { get; set; }
        // int bronze;
        public int total { get; set; }
       // int total;

        /*
        public CWG(int code, string name, int year, int gold, int silver, int bronze, int total)
        {
            this.code = code;
            this.name = name;
            this.year = year;
            this.gold = gold;
            this.silver = silver;
            this.bronze = bronze;
            this.total = total;
        }
        */

        public string info()
        {
            return $"Code : {this.code} Name : {this.name} Gold : {this.gold} Silver : {this.silver} Bronze : {this.bronze} Total :{this.total}";
        }
        public static void CWGDemo()
        {
            var CWGList = new List<CWG>()
            {
                new CWG { code = 1, name = "Australia", gold = 67, silver = 57, bronze = 54, total = 178 },
                new CWG { code = 2, name = "England", gold = 57, silver = 66, bronze = 53, total = 176 },
                new CWG { code = 3, name = "Canada", gold = 26, silver = 32, bronze = 34, total = 92 },
                new CWG { code = 4, name = "India", gold = 22, silver = 16, bronze = 23, total = 61 },
                new CWG { code = 5, name = "New Zealand", gold = 20, silver = 12, bronze = 17, total = 49 },

            };

           
          // Console.WriteLine(CWGList.Count);

            Console.WriteLine("Top 5 Countries of CWG 2022 games of the list is ");
            Console.WriteLine("**************************");

            for(var i=0;i<CWGList.Count;i++)
            {
                Console.WriteLine(CWGList[i].code + " " + CWGList[i].name+" " + CWGList[i].gold+" " + CWGList[i].silver+" " + CWGList[i].bronze+" "+CWGList[i].total);
            }
            CWGList.RemoveAt(0);
           // Console.WriteLine("************************");
            Console.WriteLine("*********After Removing the Australia***********");
            //Console.WriteLine("************************");

            // Console.WriteLine(CWGList[i].code + " " + CWGList[i].name + " " + CWGList[i].gold + " " + CWGList[i].silver + " " + CWGList[i].bronze + " " + CWGList[i].total);
            foreach (var i in CWGList)
            {
                Console.WriteLine(i.info());
            }
            Console.WriteLine("Increasing the gold medals for India");
            int total = 0;
            foreach (var item in CWGList)
            {
                if (item.name == "India")
                {
                    item.gold += 2;
                    item.total += 2;
                    break;
                }
                Console.WriteLine(item.info());
            }

                var suma=from s in CWGList
                         where s.name=="India"
                         select s;


                foreach(var i in suma)
                {
                    Console.WriteLine(i.info());
                }
            }

        }
    }

