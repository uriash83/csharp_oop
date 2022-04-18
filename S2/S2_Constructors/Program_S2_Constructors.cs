using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Constructors
{
    public class Program_S2_Constructors
    {
        public static void S2_Constructors()
        {
            var customer = new Customer(9);
            var customer2 = new Customer(13, "Martin");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);

            var customer3 = new Customer
            {
                Id = 5,
                Name = "Martin"// object initalization syntax
            };

            Console.WriteLine(customer3.Id);
            Console.WriteLine(customer3.Name);
        }
    }
}
