using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        Console.WriteLine("Welcome to the Youtube Comment Section Activity!");
        Thread.Sleep(2000);
        Console.Clear();

        Video v1 = new Video();
        v1.Title = "Top Gun Maverick Soundtrack";
        v1.Author = "Jon Nicoles";
        v1.LengthSeconds = 600;
        v1.AddComment("Johny Maverick", "Great video, very beautiful music!");
        v1.AddComment("coolbro", "Thanks, this helped me a lot!");
        v1.AddComment("SwaggyGuy", "Literally the best soundtrack ever");
        videos.Add(v1);

        Video v2 = new Video();
        v2.Title = "Lord of The Rings Best Fight Scene";
        v2.Author = "Peter Jackson";
        v2.LengthSeconds = 480;
        v2.AddComment("Paul Revere", "Awesome video. Really Hyped me up!");
        v2.AddComment("KevenHart", "Can you make a video about the different elves?");
        v2.AddComment("TomasG", "This was amazing. Thanks as always! ");
        videos.Add(v2);

        Video v3 = new Video();
        v3.Title = "Shrek Full Movie";
        v3.Author = "DonkeyG";
        v3.LengthSeconds = 720;
        v3.AddComment("HecktorMiles", "This is amazing, I didn't know this was legal!");
        v3.AddComment("HarryP", "best. movie. ever.");
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.PrintInfo();
        }

        Console.ReadLine();



        // List<Video> videos = new List<Video>();
        // Console.WriteLine("Welcome to the Youtube Comment Section Activity!");
        // Thread.Sleep(2000);
        // Console.Clear();

        // Video v1 = new Video();
        // string video1 = "Top Gun Maverick Soundtrack";
        // Console.WriteLine(video1);
        // v1.Title = video1;
        // v1.Author = "Joe Martinez";
        // v1.LengthSeconds = 2100;
        // Console.WriteLine("What is the username?");
        // string user1 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment1 = Console.ReadLine();
        // v1.AddComment(user1, comment1);

        // Console.WriteLine("");

        // string video2 = "Lord of the Rings Best Fight Scenes";
        // Console.WriteLine(video2);
        // v1.Title = video2;
        // v1.Author = "Tommy Bradshaw";
        // v1.LengthSeconds = 600;
        // Console.WriteLine("What is the username?");
        // string user2 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment2 = Console.ReadLine();
        // v1.AddComment(user2, comment2);

        // Console.WriteLine("");

        // string video3 = "Fortnite Best Fight Scenes";
        // Console.WriteLine(video3);
        // v1.Title = video3;
        // v1.Author = "BreezyEezy";
        // v1.LengthSeconds = 2000;
        // Console.WriteLine("What is the username?");
        // string user3 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment3 = Console.ReadLine();
        // v1.AddComment(user3, comment3);
        // videos.Add(v1);

        // Console.Clear();

        // Video v2 = new Video();
        // string video4 = "Terminal Velocity Equation";
        // Console.WriteLine(video4);
        // v1.Title = video4;
        // v1.Author = "Mark Telmart";
        // v1.LengthSeconds = 3500;
        // Console.WriteLine("What is the username?");
        // string user4 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment4 = Console.ReadLine();
        // v1.AddComment(user4, comment4);

        // Console.WriteLine("");

        // string video5 = "Monster Vs Aliens All Bob Scenes";
        // Console.WriteLine(video5);
        // v1.Title = video5;
        // v1.Author = "Ricky Martin";
        // v1.LengthSeconds = 500;
        // Console.WriteLine("What is the username?");
        // string user5 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment5 = Console.ReadLine();
        // v1.AddComment(user5, comment5);

        // Console.WriteLine("");

        // string video6 = "Starwars Strongest Sith";
        // Console.WriteLine(video6);
        // v1.Title = video6;
        // v1.Author = "Starwars Machine";
        // v1.LengthSeconds = 1500;
        // Console.WriteLine("What is the username?");
        // string user6 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment6 = Console.ReadLine();
        // v1.AddComment(user6, comment6);
        // videos.Add(v2);

        // Console.Clear();

    
        // Video v3 = new Video();
        // string video7 = "Web Telescope";
        // Console.WriteLine(video7);
        // v1.Title = video7;
        // v1.Author = "NASA";
        // v1.LengthSeconds = 3500;
        // Console.WriteLine("What is the username?");
        // string user7 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment7 = Console.ReadLine();
        // v1.AddComment(user7, comment7);

        // Console.WriteLine("");

        // string video8 = "Best Animal Fights";
        // Console.WriteLine(video8);
        // v1.Title = video8;
        // v1.Author = "National Geographic";
        // v1.LengthSeconds = 1800;
        // Console.WriteLine("What is the username?");
        // string user8 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment8 = Console.ReadLine();
        // v1.AddComment(user8, comment8);

        // Console.WriteLine("");

        // string video9 = "Flushed Away Full Movie";
        // Console.WriteLine(video9);
        // v1.Title = video9;
        // v1.Author = "Pirated Movies";
        // v1.LengthSeconds = 4500;
        // Console.WriteLine("What is the username?");
        // string user9 = Console.ReadLine();
        // Console.WriteLine("What is the comment?");
        // string comment9 = Console.ReadLine();
        // v1.AddComment(user9, comment9);
        // videos.Add(v3);

        // Console.Clear();

        // foreach (Video v in videos)
        // {
        //     v.PrintInfo();
        // }

        // Console.ReadLine();
    }
}