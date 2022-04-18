
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S4.S4_Boxing
{
    internal class Program_S4_Boxing
    {
        public static void S4_Boxing()
        {
            //value types
            // stoerd in the stack
            // all primitives - bool,int,float, struct  ...
            // short lifetime, after scope they are dead



            // reference types
            // stored in the heap
            // all object, String, Array ....

            //boxing - przypisanie jakiejs wartosci/obiektu 
            int number = 10;
            object obj = number; // to jest boxing

            object objj = 10;// liczba bedzie zapisaca na heap zamiast na stack


            var list = new ArrayList();
            list.Add(1); // bedzie boxingbo kazdy typ jest typu object i bdzie boxing z object to int
            list.Add("fdsag");
            // we loose type safety
            var num = (int)list[1]; // niby ok ale bedzie exeption bo nie da sie string->int

            var newList = new List<string>(); // tutaj nie bedzie boxingu bo wszystko musi byc string
            // lista generyczna lepsza od arraylist
            

        }
    }
}
