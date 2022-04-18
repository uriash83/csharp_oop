using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_OOP.S4.S4_Upcast_downcast
{
    internal class Program_S4_Upcast_downcast
    {
        public static void S4_Upcast_downcast()
        {
            // upcasting
            Text text = new Text();
            text.Width = 50;
            text.Height = 50;   
            Shape shape = text;

            Console.WriteLine(shape.Width + shape.Height);



            // dpwncasting
            Shape sh = new Text(); // to jest obieky typu Shape
            Text tx = (Text)sh; // downcasting to text
            
            

        }
    }
}
