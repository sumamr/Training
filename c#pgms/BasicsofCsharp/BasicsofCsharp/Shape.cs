using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCsharp
{
    internal abstract  class Shape
    {
        public abstract void draw();
        
        public void info()
        {
            Console.WriteLine("I am Shape Abstract class");
        }
    }
    internal class Circle : Shape
    {

      
        public override void draw()
        {
            Console.WriteLine("I am Circle Class ");
        }
        public void OtherShape()
        {
            Console.WriteLine("By using Circle we can create other shapes");
        }
    }

    internal class abstractDemo
    {
        public static void testDemo()
        {
            Shape s=new Circle();
            s.draw();
            s.info();

            Circle c=new Circle();
            c.OtherShape();
        }
    }
}
