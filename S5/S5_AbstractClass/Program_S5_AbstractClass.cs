using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S5.S5_AbstractClass
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rec");
        }
    }
    internal class Program_S5_AbstractClass
    {
        public static void S5_AbstractClass()
        {
            //var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rec = new Rectangle();
            rec.Draw();
        }
    }
}
