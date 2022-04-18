using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Method
{
    internal class Program_S2_Method
    {
        public static void S2_Method()
        {
            var Point = new Point(20, 30);
            Point.Move( new Point(4,5));
            Console.WriteLine("Point X: {0} and Y: {1}",Point.X, Point.Y);
            Point.Move(40, 60);
            Console.WriteLine("Point X: {0} and Y: {1}", Point.X, Point.Y);
            //Point.Move(null);

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(2,3,65));

            





        }

        
    }
}
