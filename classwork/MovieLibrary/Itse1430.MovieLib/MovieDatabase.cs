using System;
using System.Collections.Generic;
using System.Linq;

namespace Itse1430.MovieLib
{
    /// <summary>Manages the movies in a database.</summary>
    public abstract class MovieDatabase : IMovieDatabase
    {
        public Movie Add ( Movie movie )
        {
            //TODO: Validation
            if (movie == null)
                return null;

            //if (!String.IsNullOrEmpty(movie.Validate()))
            //var context = new ValidationContext(movie);
            //var results = movie.Validate(context);
            var results = ObjectValidator.TryValidateObject (movie);
            if (results.Count () > 0)
                return null;

            //Name must be unique
            var existing = GetByNameCore (movie.Title);
            if (existing != null)
                return null;

            return AddCore (movie);
        }

        public void Remove ( int id )
        {
                RemoveCore (id);
        }

        public Movie Get ( int id )
        {
            //TODO: Validate
            if (id <= 0)
                return null;

            return GetCore (id);
        }

        protected abstract Movie GetCore ( int id );

        public IEnumerable<Movie> GetAll ()
        {
            return GetAllCore ();
        }

        protected abstract IEnumerable<Movie> GetAllCore ();

        public void Update ( int id, Movie newMovie )
        {
            //TODO: Validate
            if (id <= 0)
                return;
            if (newMovie == null)
                return;

            //if (!String.IsNullOrEmpty(movie.Validate()))
            //var context = new ValidationContext(newMovie);
            //var results = newMovie.Validate(context);
            var results = ObjectValidator.TryValidateObject (newMovie);
            if (results.Count () > 0)
                return;

            //Must be unique
            var existing = GetByNameCore (newMovie.Title);
            if (existing != null && existing.Id != id)
                return;

             UpdateCore (id, newMovie);
        }

        protected abstract Movie UpdateCore ( int id, Movie newMovie );


        /// <summary>Add a movie to database.</summary>
        /// <param name="movie">Movie to add.</param>
        /// <returns>Updated movie.</returns>
        protected abstract Movie AddCore ( Movie movie );

        protected abstract void RemoveCore ( int id );

        protected abstract Movie GetByNameCore ( string name );       
    }
}
