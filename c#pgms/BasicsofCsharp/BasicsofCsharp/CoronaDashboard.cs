using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicsofCsharp
{
    internal class CoronaDashboard
    {

        public  List<Corona> listname = new List<Corona>();
      //  listname.Add(new Corona(code, name, active, recovered, death, total));
        public  void addCoronaData(Corona corona)
        {

              listname.Add(corona);
           // return listname;
           
        }
       
        public  void updateCoronaData(Corona corona)
        {
            listname.Add(corona);

        }
        public  void deleteCoronaData(Corona corona)
        {
            //listname.Add(new Corona(code, name, active, recovered, death, total));
            int del = -1;
            foreach(var s in listname)
            {
                if(s.name.Equals(corona.name))
                {
                    del=listname.IndexOf(s);
                    break;
                }
                
            }
            listname.RemoveAt(del);

            Console.WriteLine("After Deleting the Corona Data");
            foreach(var s in listname)
            {
                Console.WriteLine(s.info());
            }

        }
        
        public void displayTopState()
        {
            Console.WriteLine("*****Finding Death Rate************");
            int Totaldeath = 0;
            foreach(var s in listname)
            {
                Totaldeath=Totaldeath+s.death;
            }
            Console.WriteLine("Total number of deaths in all states  is "+Totaldeath);

            double deathrate = 0;
            double totalCases = 0;
            foreach (var s in listname)
            {
                totalCases = totalCases + s.active;
                deathrate = (Totaldeath / totalCases)*100;//ans:13.0
            }
            Console.WriteLine("Death Rate is "+deathrate);
            int maxDeath = -1;
            foreach (var s in listname)
            {
                if (maxDeath < s.death)
                {
                    maxDeath =  s.death;
                }
            }
            Console.WriteLine("*****Top state According to DeathRate*******");
            Console.WriteLine("Top State in Corona Datalist according to death is : "+maxDeath);
            foreach(var s in listname)
            {
                if(maxDeath == s.death)
                Console.WriteLine(s.info());
            }
        }

        
        public  void listCoronaData()
        {
            foreach(var c in listname)
            {
                Console.WriteLine(c.info());
            }
        }
    }
    }

