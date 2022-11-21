using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Account
    {
        public int accountnumber;
        public string name;
        public string email;
        public string mobile;
        float balance=0;

        public Account(int accountnumber, string name, string email, string mobile, float balance)
        {
            this.accountnumber = accountnumber;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.balance =balance;
        }
        public string info()
        {
            return $"\nAccount Number : {this.accountnumber} \nName : {this.name} \nEmail : {this.email} \nMobile : {this.mobile} \nBalance : {this.balance}";
        }

        public float DepositAmt(int accountnumber,float damt)
        {
            if(accountnumber == this.accountnumber)
            {
                Console.WriteLine("Deposited the amount is "+damt);
                balance += damt;
                return balance;
            }
            else
            {
                Console.WriteLine($"Account number not matching ");
                return -1;
            }
            
        }
        public float WithdrawAmt(int accountnumber,float wamt)
        {
            if(accountnumber==this.accountnumber)
            {
                Console.WriteLine($"Withdraw amount is "+wamt);
                balance -= wamt;
                return balance;
            }
            else
            {
                Console.WriteLine($"Account Number is not matching");
                return -1;
            }
        }
       

         public string bal()
        {
                 return $"Balance : {this.balance}";
        }



        
    }
    
}
