using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        private int likes;

        private readonly List<String> comments;

        private int PostId;

        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }

        public static int instances = 0;

        public Post(string author)
        {
            instances++;
            PostId = instances;
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<string>();
        }

        public void Like()
        {
            likes++;
        }

        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        public void AddComment(String text)
        {
            comments.Add(text);
        }

        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
