using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Accounts
    {
        public int accountNumber;
        string name;
        string email;
        string mobile;
        int balance=0;

        //public string info()
        //{
        //    return $"\nAccount Number : {this.accountNumber} \nName : {this.name} \nEmail : {this.email} \nMobile : {this.mobile} \nBalance : {this.balance}";
        //}

        public Accounts(int accountNumber, string name, string email, string mobile, int balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.balance = balance;
        }
        public Accounts()
        {
            Console.WriteLine("Default Constructor");
        }

        public void DepositAmt()
        {
                Console.WriteLine("Enter Amount to Deposit");
                int d=Convert.ToInt32(Console.ReadLine());
                balance += d;
                //return balance;

        }
        public void WithdrawAmt(float wamt)
        {
            
            try
            {
                Console.WriteLine("Enter Amount to withdraw");
                int w = Convert.ToInt32(Console.ReadLine());
                int bal;
                bal = (int)balance - w;
                if ( bal>0)
                {
                    balance -= w;
                    //throw new Exception("Insufficient Balance");
                }
                else
                {
                    
                    //Console.WriteLine("Amount Withdrawn Successfully");
                    throw new InsufficientBalance("Insufficient Balance");
                    
                }
               
               // return balance;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            //Console.WriteLine(Exception.m);
        }

        internal class InsufficientBalance:Exception
        {
            public InsufficientBalance()
            {
                Console.WriteLine("Insufficient Balance");
            }
            public InsufficientBalance(string msg) : base(msg) { }
        }
        
        public void CheckBalance(int accountno)
        {

            //Console.WriteLine("Enter Account Number to Check the Balance");
            //int an = Convert.ToInt32(Console.ReadLine());
            //if(an==this.accountNumber)
            {

                Console.WriteLine("Balance is " + balance);
                //}
                //else
                //{ 
                //    Console.WriteLine("Entered wrong Account Number");

                }

            }


    }
}
    