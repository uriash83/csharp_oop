using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP.S2.S2_Exercise
{
    internal class Program_S2_Exercise
    {
        public static void S2_Exercise()
        {
            var post = new Post("new error", "i have a big problem", DateTime.Now);
            Console.WriteLine(post.Title + post.Description + post.CreatedAt);
            post.downVote();
            post.downVote();
            post.downVote();
            Console.WriteLine(post.Votes);
            post.UpVote();
            Console.WriteLine(post.Votes);

        }

           
    }
}
