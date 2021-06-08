using System;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        private int PostCount = 0;

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
                    case 4:
                    case 5: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            Console.WriteLine("Enter file name: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Enter Caption: ");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(news.GetAuthor(), filename, caption);
            news.AddPhotoPost(post);
        }

        private void PostMessage()
        {
            Console.WriteLine("Enter your message");
            PostCount++;
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(news.GetAuthor(), message, PostCount);
            news.AddMessagePost(post);
        }
        
        private void DeleteMessage()
        {
            news.RemovePost()
        }
    }
}
