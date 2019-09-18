using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>Represents movie data.</summary>
    public class Movie
    {
        // fields - data to be stored
        // never make fields public
        public string title = "";
        public string description = "";
        public int releaseYear = 1900;
        public string rating = "";
        public bool hasSeen;
        public int runLength;

        /// <summary>Validates the movie.</summary>
        /// <returns>An error message if validation fails or empty string owtherwise.</returns>
        public string Validate()
        {
            // this is implicit first parameter, represents instance
            var title = "";

            // Name is required
            if (String.IsNullOrEmpty (this.title))
                return "Title is required";

            // Release year >= 1900
            if (releaseYear > 1900)
                return "Release year must be >+1900";

            // run length >= 0
            if (runLength < 0)
                return "Run Length must be >= 0";

            //rating is required
            if (String.IsNullOrEmpty (rating))
                return "Rating is required";

            return "";
        }
        // Can new up other objects
        //private Movie originalMovie = new Movie ();
    }
}
