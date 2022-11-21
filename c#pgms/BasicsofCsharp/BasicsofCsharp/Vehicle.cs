using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal class Vehicle
    {
        public string name;
        public string model;
        public string make;
        public float price;
        public string color;
       protected int speed;


        public void start()
        {
            Console.WriteLine("Vehicle is started");
            //speed=0;
            this.speed = 0;
        }
        public void move()
        {
            Console.WriteLine("Vehicle has moved");
            this.speed = this.speed + 5;
        }
        public void stop()
        {
            Console.WriteLine("Vehicle is stopped");
            //speed=0;
            this.speed = 0;
        }
        public string info()
        {
            Console.WriteLine("Information about Vehicle");
            return $"\nName : {this.name} \nModel : {this.model} \nMake : {this.make} \nPrice : {this.price} \nColor : {this.color} \nSpeed : {this.speed}";
        }
    }
    internal class Car : Vehicle
    {
        public string ac;

        public void move()
        {
            Console.WriteLine("Car has moved");
            this.speed = this.speed + 10;
        }

    }

}
