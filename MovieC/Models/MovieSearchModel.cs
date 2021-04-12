using System;
namespace MovieC.Models
{
    public class MovieSearchModel
    {
        public MovieSearchModel(string name, Movie genre)
        {
            Title = name;
            Genre = genre;
        }

        public string Title { get; set; }
        public Movie Genre { get; set; }
    }
}
