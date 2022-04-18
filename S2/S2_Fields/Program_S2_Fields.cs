using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Fields
{
    internal class Program_S2_Fields
    {
        public static void S2_Fields()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);



        }
    }
}
