using System;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        private int PostCount = 0;

        /// <summary>
        /// this method allows the user to see the time now, their news feed 
        /// and 4 choices post image, post message, display all and quit
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Brian's News Feed");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "DisplayMenu All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choices)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// This method allows the user to post their photo/image
        /// </summary>
        private void PostImage()
        {
            Console.WriteLine("Enter file name: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Enter Caption: ");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(news.GetAuthor(), filename, caption);
            news.AddPhotoPost(post);
        }

        /// <summary>
        /// This method allows the user to post their message
        /// </summary>
        private void PostMessage()
        {
            Console.WriteLine("Enter your message");
            PostCount++;
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(news.GetAuthor(), message, PostCount);
            news.AddMessagePost(post);
        }
        
        /// <summary>
        /// This method allows the user to enter the id of the post they would like
        /// to remove
        /// </summary>
        private void DeleteMessage()
        {
            Console.WriteLine("Please enter the id of the post you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            news.RemovePost(id);
        }
    }
}
