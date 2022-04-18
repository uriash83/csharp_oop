using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S4.S4_Access_Modifiers
{
    internal class Program_S4_Access_modifiers
    {
        
        public static void S4_Access_Modifiers()
        {
            //protected internal - albo widoczny w obrebie assembly albo w obrebie klasy dziedziczacej
            var customer = new Customer();
            Amazon.Customer customer2 = new Amazon.Customer();  
        }
    }
}
