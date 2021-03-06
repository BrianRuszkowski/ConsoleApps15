using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {

        // the name of the image file
        public String Filename { get; set; }

        // a one line image caption
        public String Caption { get; set; }


        /// <summary>
        /// this method shows the filename and caption of the post
        /// </summary>
        /// <param name="author"></param>
        /// <param name="filename"></param>
        /// <param name="caption"></param>
        /// <param name="id"></param>
        public PhotoPost(String author, String filename, String caption, int id):base(author, id)
        {
            this.Filename = filename;
            this.Caption = caption;
        }

        public override void Display()
        {
            Console.WriteLine($" Filename: [{Filename}]");
            Console.WriteLine($" Caption: {Caption}");

            base.Display();
        }
    }
}