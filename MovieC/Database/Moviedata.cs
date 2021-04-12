using System;
using System.Collections.Generic;
using MovieC.Models;

namespace MovieC.Database
{
    public class Moviedata : IMovieData
    {
        public List<Movie> Get()
        {
            var results = new List<Movie>();

            results.Add(new Movie("Big Mammas House", "Comdey"));
            results.Add(new Movie("Inception", "Thriller"));
            results.Add(new Movie("Interstellar", "Thriller"));
            results.Add(new Movie("Joker", "Thriller"));
            results.Add(new Movie("The Perfect Stranger", "Thriller"));
            results.Add(new Movie("Judas and Messiah", "Drama"));
            results.Add(new Movie("1917", "Drama"));
            results.Add(new Movie("Pyscho", "Horror"));
            results.Add(new Movie("Haunted House on the Hill", "Horror"));
            results.Add(new Movie("Sweet November", "Romance"));
            results.Add(new Movie("Cider House Rules", "Romance"));
            results.Add(new Movie("Grease", "Musical"));
            results.Add(new Movie("Godfather", "Crime"));


            return results;





        }
    }
}
