using System;
using System.Collections.Generic;
using MovieC.Models;

namespace MovieC.Database
{
    public interface IMovieData
    {
        List<Movie> Get();

     
    }
}
