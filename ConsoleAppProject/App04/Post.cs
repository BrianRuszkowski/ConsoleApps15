using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        private int likes;

        private readonly List<String> comments;

        public int PostId;

        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }

        public static int instances = 0;

        /// <summary>
        /// this method shows the user's post amount of likes comments and the
        /// time it has been uploaded
        /// </summary>
        /// <param name="author"></param>
        public Post(string author)
        {
            instances++;
            PostId = instances;
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<string>();
        }

        /// <summary>
        /// This method allows the user to like a post
        /// </summary>
        public void Like()
        {
            likes++;
        }

        /// <summary>
        /// This method allows the user to unlike the photo they previously
        /// liked
        /// </summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        /// <summary>
        /// This method allows the user to add a comment
        /// </summary>
        /// <param name="text"></param>
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($" Author: {Username}");
            Console.WriteLine($" Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if(likes > 0)
            {
                Console.WriteLine($" Likes: {likes} people like this.");
            }
            else
            {
                Console.WriteLine();
            }
            if (comments.Count == 0)
            {
                Console.WriteLine(" No Comments.");
            }
            else
            {
                Console.WriteLine($" {comments.Count} comment(s). Click here to view.");
            }
        }


        /// <summary>
        /// this method shows the time of the post posted
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
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
