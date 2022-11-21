using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class RBI
    {
        public float roi = 0F;
        public virtual float rateOfInterest()
        {
          
            roi = 2.5f;
            return roi;
        }
    }
    internal class SBI : RBI
    {
       // public  virtual float roi = 0F;
        public override float rateOfInterest()
        {

            roi = 5f;
            return roi;
        }
        public void info()
        {
            Console.WriteLine("I am SBI Bank");
        }

    }
    internal class HDFC : RBI
    {
       //public float roi = 0F;
        public override float rateOfInterest()
        {

            roi = 7f;
            return roi;
        }
    }
    internal class Corporation : RBI
    {
        public override float rateOfInterest()
        {
            roi = 3.5f;
            return roi;
        }
    }
}
