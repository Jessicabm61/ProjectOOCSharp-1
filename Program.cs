using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip!"); //Instancia um objeto do tipo Comment
            Comment c2 = new Comment("Wow that's awesome!"); //Instancia um objeto do tipo Comment
            Post p1 = new Post( //Instancia um objeto do tipo P1
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);
            p1.AddComment(c1); //Adiciona a instanciação C1 e C2 no objeto P1
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");//Instancia um objeto do tipo Comment
            Comment c4 = new Comment("May the Force be with you");//Instancia um objeto do tipo Comment
            Post p2 = new Post(//Instancia um objeto do tipo P2
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);
            p2.AddComment(c3);//Adiciona a instanciação C3 e C4 no objeto P2
            p2.AddComment(c4);

            Console.WriteLine(p1); //Imprime o objeto
            Console.WriteLine(p2);
        }
    }
}
