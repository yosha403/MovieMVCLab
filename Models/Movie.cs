using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        Romance
    }
    public class Movie
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
