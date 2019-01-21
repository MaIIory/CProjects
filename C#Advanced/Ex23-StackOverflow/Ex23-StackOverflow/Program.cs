using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("Null Reference Exception", "I have got stack with following Excxeption: NullReferenceExcxpetion. I don't how to fix it please, help!");

            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.DownVote();
            post1.DownVote();

            post1.ShowRating();
        }
    }
}
