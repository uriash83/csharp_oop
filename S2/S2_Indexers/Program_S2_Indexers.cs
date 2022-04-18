using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Indexers
{
    internal class Program_S2_Indexers
    {
      public static void S2_Indexers()
        {
            var cookie = new Cookie();
            cookie["name"] = "Martin";
            Console.WriteLine(cookie["name"]);
        }
    }
}
