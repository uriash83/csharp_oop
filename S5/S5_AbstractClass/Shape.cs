namespace Course_OOP.S5.S5_AbstractClass
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public  void Copy()
        {
            Console.WriteLine("Copy to clipborad");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape");
        }

    }
}
