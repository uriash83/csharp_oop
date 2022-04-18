using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Init
{
    public class Program_S2_Init
    {
        public static void S2_Init()
        {
            Person person = new Person();
            person.Name = "Martin";
            person.Introduce("Tom");

            var p = Person.Parse("Jerry");
            p.Introduce("Mosh");
        }
    }
}
