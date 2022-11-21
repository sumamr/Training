using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    interface IUniversalRemote
    {
        public void switchOn();
        public void switchOff();

      public void changeChannel(string channel);
       public void changeVolume(int channeVolume);

        //public string changeChannel(string channel)
        //public int changeVolume(int volume)
        //TCLTV has to implement IUniversalRemote
    }

    internal class SONYTV : IUniversalRemote
    {
        bool tvStatus = false;

        string currentchannel="";
        int currentvolume=0;

        public void changeChannel(string channel)
        {
            currentchannel = channel;
           Console.WriteLine("Current Channel Changed to " + channel);
          //  return currentchannel;
           
           // throw new NotImplementedException();
        }

        public void changeVolume(int Volume)
        {
            Volume=Convert.ToInt32(Volume);
            Volume =Volume+currentvolume;
           // return Volume;
           Console.WriteLine("Volume Changed to "+Volume);
   
           // throw new NotImplementedException();
        }
        public void switchOff()
        {
           // throw new NotImplementedException();
           if(tvStatus)
            {
                tvStatus = true;
                Console.WriteLine("Sony Tv is Switched Off");


            }
            else
            {
                Console.WriteLine("Sony Tv is already in ON State");
            }
        }

        public void switchOn()
        {
            // throw new NotImplementedException();
            if(!tvStatus)
            {
                tvStatus= true;
                Console.WriteLine("Sony TV is already in ON State");
            }
            else
            {
                Console.WriteLine("Sony TV is Off State");
            }

        }
    }
    internal class Interface
    {

    }
}
