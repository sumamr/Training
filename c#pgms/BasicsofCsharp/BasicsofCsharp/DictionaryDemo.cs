using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class DictionaryDemo
    {
        public static void demo1()
        {
            Console.WriteLine("****Adding Values using Add() Method****");
            Dictionary<int, string> suma = new Dictionary<int, string>();
            suma.Add(1, "Suma");
            suma.Add(2, "Manju");
            suma.Add(3, "Sudha");

            foreach(KeyValuePair<int, string> pair in suma)
            {
               // Console.WriteLine("Key: {0} ,Value: {1}", pair.Key, pair.Value);
                Console.WriteLine($"Key : {pair.Key}, Value : {pair.Value}");
            }
            Console.WriteLine("****Creating Dictionary by creating Objects****");
            var Cities = new Dictionary<int, string>()
            {
                {1,"Maddur" },
                {2,"Channaptan" },
                {3,"Mandya" }


            };
            foreach(KeyValuePair<int, string> pair in Cities)
            {
                Console.WriteLine("Key : {0}, Value : {1}",pair.Key, pair.Value);
            }

        }
        public static void demo2()
        {
            Console.WriteLine("****Acessing Dictionary Elements****");
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            

            Console.WriteLine("---access elements using for loop---");
            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }
        }
        public static void demo3()
        {
            Console.WriteLine("****Updating Dictionary****");
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
           };

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
        }
        public static void demo4()
        {
            Console.WriteLine("****Removing Dictionary Element****");
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Clear(); //deletes all elements

            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

        }
    }
    }

