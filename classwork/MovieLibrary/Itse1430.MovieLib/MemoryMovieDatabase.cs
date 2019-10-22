using System;
using System.Collections.Generic;

namespace Itse1430.MovieLib
{
    /// <summary>Manages the movies in a database.</summary>
    public class MemoryMovieDatabase : MovieDatabase
    {     

        protected override Movie AddCore ( Movie movie )
        {//Add movie
            movie.Id = ++_id;

            var newMovie = Clone (new Movie (), movie);
            _movies.Add (newMovie);

            return movie;
        }        

        protected override Movie GetCore ( int id )
        {
            var movie = FindMovie (id);
            return movie != null ? Clone (new Movie (), movie) : null;
        }       

        protected override IEnumerable<Movie> GetAllCore ()
        {
            foreach (var movie in _movies)
                yield return Clone (new Movie (), movie);

            //Using an array, the hard way
            //var index = 0;
            //var movies = new Movie[_movies.Count];
            //foreach (var movie in _movies)
            //    if (movie != null)
            //        movies[index++] = Clone(new Movie(), movie);

            //return movies; 
        }

        protected override Movie GetByNameCore ( string name )
        {
            foreach (var movie in _movies)
                if (String.Compare (movie.Title, name, true) == 0)
                    return movie;

            return null;
        }

        protected override void RemoveCore ( int id )
        {
            var movie = FindMovie (id);
            if (movie != null)
                _movies.Remove (movie);
        }

        protected override Movie UpdateCore (int id, Movie newMovie )
        {
            var existing = FindMovie (id);
            if (existing == null)
                return null; //TODO: Error

            //Update existing movie
            newMovie.Id = id;
            Clone (existing, newMovie);

            return newMovie;
        }

        private Movie Clone ( Movie target, Movie source )
        {
            target.Id = source.Id;
            target.Description = source.Description;
            target.HasSeen = source.HasSeen;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.RunLength = source.RunLength;
            target.Title = source.Title;

            return target;
        }

        private Movie FindMovie ( int id )
        {
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }

        //private Movie[] _movies = new Movie[100];
        //Dynamically resizing array
        private List<Movie> _movies = new List<Movie> ();

        //Identical to List<T>, just wrong namespace
        // using System.Collections.ObjectModel;
        //private Collection<Movie> _movies = new Collection<Movie>();
        private int _id = 0;
    }
}
