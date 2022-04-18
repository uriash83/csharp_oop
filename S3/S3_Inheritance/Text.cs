namespace Course_OOP.S3.S3_Inheritance
{
    public class Text : PrecentationObject
    {
        public int Fontsize { get; set; }
        public string  FontName { get; set; }

        public void AddHyperLink(string link)
        {
            Console.WriteLine("Link ad added to " + link);
        }
    }
}
