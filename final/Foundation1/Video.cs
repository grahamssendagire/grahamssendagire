using System;
using System.Collections.Generic;

namespace VideoComments
{
    // defining a class called a video.
 class Video
    {
    //Defining the responsibilities(variables) as public for the video class.
     public string Title { get; set; }
     public string Author { get; set; }
     public int Length { get; set; }
     public List<Comment> Comments { get; set; }

     public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }
   
    }

}