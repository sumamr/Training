using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{

    interface IUniversal
    {
        public void swithOn();

        public void swithOff();

        public void changeChannel(string channel);
        public void changeVolume(int volume);


    }

    internal class TCLTV : IUniversal
    {

        bool  tvState=false;
        string currentChannel = "";
        int currentVolume = 10;


        public void changeChannel(string channel)
        {
            currentChannel = channel;
           // Console.WriteLine(channel);
            Console.WriteLine("Channel Changed to : " +channel); ;
            //throw new NotImplementedException();
        }

        public void changeVolume(int volume)
        {
            currentVolume = volume;
            if(volume>currentVolume)
            {
                Console.WriteLine("Tv Volume is Increased to : "+volume);
            }
            else
            {
                Console.WriteLine("Tv Volume is Decreased to : " + volume);
            }
            //throw new NotImplementedException();
        }

        public void swithOff()
        {
            if(tvState)
            {
                tvState=false;
                Console.WriteLine("TCL TV is in OFF State");
            }
            else
            {
                Console.WriteLine("TCL TV is already in ON state");
            }
            //throw new NotImplementedException();
        }

        public void swithOn()
        {
            if(!tvState)
            {
                tvState = true;
                Console.WriteLine("TCL TV is already in ON State");

            }
            else
            {
                Console.WriteLine("TCL TV is Switched Off");
            }
           // throw new NotImplementedException();
        }
    }
    internal class Interface1
    {
        public static void testInterface()
        {
            IUniversal u = new TCLTV();
            u.swithOn();
            u.swithOff();
            u.changeChannel("UdayaTv");
            u.changeVolume(5);
            
        }
    }
}
