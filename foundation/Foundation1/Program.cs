using System;

class Program
{
    static void Main(string[] args)
    { 
        //List to store video objects
        List<Video> videoList = new List<Video>();  
        
        
         //Comments for back to the future movie
        Comment user1Comment = new Comment("Angela", "Great Movie");        
        Comment user2Comment = new Comment("James", "Hated the movie");
        Comment user1Comment2 = new Comment("Angela", "forgot to say I would watch it again");

        Video backToTheFuture = new Video("backToTheFuture", "Lanny Smith", 120);
        videoList.Add(backToTheFuture);
        backToTheFuture.AddComment(user1Comment);
        backToTheFuture.AddComment(user2Comment);
        backToTheFuture.AddComment(user1Comment2);
   

       //Comments for lonely hearts movie
       Comment user3Comment = new Comment("Terry", "What a great movie, cried a ton!");
       Comment user4Comment = new Comment("Jacob", "Too girly for me, but not bad");    
       Comment user5Comment = new Comment("Yesenia", "What heart-warming movie, 10 out of 10");
      
        Video lonelyHeartsMovie = new Video();
        lonelyHeartsMovie.SetTitle("LonglyHearts");
        lonelyHeartsMovie.SetAuthor("Andrew Taylor");
        lonelyHeartsMovie.SetLength(162);
        videoList.Add(lonelyHeartsMovie);
        Console.WriteLine(lonelyHeartsMovie.GetTitle());
        lonelyHeartsMovie.AddComment(user3Comment);
        lonelyHeartsMovie.AddComment(user4Comment);
        lonelyHeartsMovie.AddComment(user5Comment);
        

         //comments for The Notebook movie 
         Comment user6Comment = new Comment("Teresa", "Completely unexpected, great ending");   
         Comment user7Comment   = new Comment("Arnold", "Great movie to watch on a date");
         Comment user8Comment = new Comment("Caroline", "5 stars!");
         
         Video theNotebookMovie = new Video("The Notebook", "John Smith", 160);
        
         videoList.Add(theNotebookMovie);
         theNotebookMovie.AddComment(user6Comment);
         theNotebookMovie.AddComment(user7Comment);
         theNotebookMovie.AddComment(user8Comment);
       
      
        foreach(Video video in videoList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
        
    }
}