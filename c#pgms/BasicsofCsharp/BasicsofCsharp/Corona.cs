using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Corona
    {
        public int code { get; set; }
        public string name { get; set; }
        public int active { get; set; }
        public int recovered { get; set; }
        public int death{ get; set; }
        public int total{ get; set; }

       /* public Corona()
        {
            Console.WriteLine("Default Constructor");
        }
        */
        public Corona(int code, string name, int active, int recovered, int death, int total)
        {
            this.code = code;
            this.name = name;
            this.active = active;
            this.recovered = recovered;
            this.death = death;
            this.total = total;
        }

        public string info()
        {
            return $"Code : {this.code} Name : {this.name} Active : {this.active} Recovered : {this.recovered} Death : {this.death} Total : {this.total}";
        }
    }

    
    
    
}
