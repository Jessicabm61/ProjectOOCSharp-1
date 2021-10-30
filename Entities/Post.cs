using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>(); //list object Comments 1 para muitos

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) //Add um item a lista
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) //Remove um item da lista
        {
            Comments.Remove(comment);
        }

        public override string ToString() //To string para imprimir a Classe
        {
            StringBuilder sb = new StringBuilder(); //Utilizando StringBuider para impressão da string
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) //Chama comments de C
            {
                sb.AppendLine(c.Text); //Imprime a lista comments.Text
            }
            return sb.ToString();
        }
    }
}
