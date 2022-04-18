using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Access_modifier
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthday(DateTime birthday)
        {
            this._birthdate = birthday;
        }
        public DateTime GetBirthday()
        {
            return this._birthdate; 
        }

    }
    internal class Program_S2_Access_modifier
    {
        public static void S2_Access_modifier()
        {
            var person = new Person();
            person.SetBirthday(new DateTime(2000,02,02));
            Console.WriteLine(person.GetBirthday());
            
        }
    }
}
