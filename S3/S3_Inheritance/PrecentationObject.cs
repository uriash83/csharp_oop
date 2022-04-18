namespace Course_OOP.S3.S3_Inheritance
{
    public class PrecentationObject
    {
        public int Witdh { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied do clipboard");

        }
        public void Duplicate()
        {
            Console.WriteLine("Object duplicated do clipboard");
        }
    }
}
