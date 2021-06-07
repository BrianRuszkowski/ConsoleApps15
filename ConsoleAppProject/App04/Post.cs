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

        public Post(string author)
        {
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        ///<summary>
        /// Record one more 'Like' indication from a user
        ///</summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has removed their 'like'. 
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {

            }
        }
    }
}
