namespace Course_OOP.S5.S5_Method_override
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw() // zeby dalo sie override , metoda musi byc virtual
        {
            Console.WriteLine("Draw from Shape"); // moze miec cialo
        }

        
    }
}
