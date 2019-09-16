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

        // Can new up other objects
        private Movie originalMovie = new Movie ();
    }
}
