namespace Course_OOP.S2.S2_Exercise
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; }
        public int Votes { get; private set; }

        public Post(string title,string description, DateTime createdat)
            :this()
        {
            
            this.Title = title;
            this.Description = description;
            this.CreatedAt = createdat;
        }
        public Post()
        {
            this.Votes = 0;
        }

        public void  UpVote()
        {
            this.Votes = this.Votes +1;
        }
        public void downVote()
        {
            this.Votes = this.Votes - 1;
        }

    }
}
