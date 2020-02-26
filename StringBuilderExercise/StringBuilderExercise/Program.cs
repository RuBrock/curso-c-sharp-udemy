using System;
using StringBuilderExercise.Entities;

namespace StringBuilderExercise {
    class Program {
        static void Main(string[] args) {

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("26/02/2020 16:07:45"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            p1.addComment(c1);
            p1.addComment(c2);

            Comment c3 = new Comment("Good night...");
            Comment c4 = new Comment("May the Force be with you!");
            Post p2 = new Post(
                DateTime.Parse("24/02/2020 22:57:45"),
                "Good Night, guys",
                "See ya tomorrow!",
                5);
            p2.addComment(c3);
            p2.addComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);

        }
    }
}
