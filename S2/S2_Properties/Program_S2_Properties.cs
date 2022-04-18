using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Properties
{


    internal class Program_S2_Properties
    {
        public static void S2_Properties()
        {
            var person = new Person(new DateTime(2020, 3, 4));
            Console.WriteLine(person.Age);

        }
    }
}
