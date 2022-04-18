namespace Course_OOP.S2.S2_Properties
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; private set; } // autoimplement properties
        // automatycznie tez tworzy pievate field, ale jak jest private set , to nie ma do niegeo dostepu

        public int Age // tu nie ma wcale setera bo nie moze byc
        {
            get
            {
                var timespan = DateTime.Today - this.Birthday;
                var years = timespan.Days / 365;

                return years;

            }
        }

        public Person(DateTime birthdate)
        {
            this.Birthday = birthdate;
        }
    }
}
