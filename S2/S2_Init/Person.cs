// See https://aka.ms/new-console-template for more information
namespace Course_OOP
{
    class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1}", Name, to);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();  
            person.Name = str;
            return person;
        }
    }
}



