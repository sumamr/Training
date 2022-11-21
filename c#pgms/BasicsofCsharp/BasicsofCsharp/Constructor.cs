using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Constructor
    {
        /*
         * Member variables
         */

        int id;
        string name;
        string email;
        string mobile;
        string city;
        
        //for creating another member variable  using prop
        //prop tab tab to create getter and setter method in csharpe

        public string country{ get; set; }
        public int zipcode{ get; set; }

        /*
         * Constructor
         */
        public Constructor(int id, string name, string email, string mobile, string city)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.city = city;

        }
        public string info()
        {
            return $"Id : {id} \nName : {name} \nEmail : {email} \nMobile : {mobile} \nCity : {city}";

        }

    }
}
