namespace Course_OOP.S5.S5_Method_override
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a circle");
        }
    }
}
