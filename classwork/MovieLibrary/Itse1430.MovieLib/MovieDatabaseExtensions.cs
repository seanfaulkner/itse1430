using System;


namespace Itse1430.MovieLib
{
    public static class MovieDatabaseExtensions
    {
        public static void seed (IMovieDatabase database)
        {
            database.Add (new Movie () { Title = "Jaws", ReleaseYear = 1979, Rating = "PG", });
            database.Add(new Movie () {Title = "Jaws 2", ReleaseYear = 1981, Rating = "PG-13", });
            database.Add(new Movie () {Title = "Star Wars", ReleaseYear = 1977, Rating = "PG", });
        }
    }
}
