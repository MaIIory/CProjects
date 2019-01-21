using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_StackOverflow
{
    class Post
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime CreationTime { get; }
        public int Rating { get; private set;  }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreationTime = DateTime.Now;
            this.Rating = 0;
        }

        public void UpVote()
        {
            this.Rating++;
        }

        public void DownVote()
        {
            this.Rating--;
        }

        public void ShowRating()
        {
            Console.WriteLine("Current rating is: {0}", this.Rating);
        }

    }
}
