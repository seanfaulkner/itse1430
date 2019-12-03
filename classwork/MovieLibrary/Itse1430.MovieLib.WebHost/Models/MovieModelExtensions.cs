/*
 * ITSE 1430 
 * 
 * Represents a movie instance.
 */
using System;

namespace Itse1430.MovieLib.WebHost.Models
{
    /// <summary>Provides extension methods for <see cref="MovieModel"/>.</summary>
    public static class MovieModelExtensions
    {
        /// <summary>Converts a model to a movie.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The movie.</returns>
        public static Movie ToDomain ( this MovieModel source )
        {
            if (source == null)
                return null;

            return new Movie () {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                HasSeen = source.HasSeen,
                Rating = source.Rating,
                ReleaseYear = source.ReleaseYear,
                RunLength = source.RunLength
            };
        }

        /// <summary>Converts a movie to a model.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The model.</returns>
        public static MovieModel ToModel ( this Movie source )
        {
            if (source == null)
                return null;

            return new MovieModel () {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                HasSeen = source.HasSeen,
                Rating = source.Rating,
                ReleaseYear = source.ReleaseYear,
                RunLength = source.RunLength
            };
        }
    }
}