using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itse1430.MovieLib.IO
{
    /// <summary>Provides a file-based movie database.</summary>
    public class FileMovieDatabase : MovieDatabase
    {
        public FileMovieDatabase ( string filePath )
        {
            //TODO: Validation
            _filePath = filePath;
        }

        protected override Movie AddCore ( Movie movie )
        {
            var movies = GetAllCore ().ToList ();

            //Figure out highest ID
            if (movies.Any ())
                movie.Id = movies.Max (m => m.Id) + 1;
            else
                movie.Id = 1;

            movies.Add (movie);
            SaveMovies (movies);

            return movie;
        }

        protected override IEnumerable<Movie> GetAllCore ()
        {
            if (File.Exists (_filePath))
            {
                var lines = File.ReadAllLines (_filePath);
                foreach (var line in lines)
                {
                    var movie = LoadMovie (line);
                    if (movie != null)
                        yield return movie;
                };
            };
        }

        private readonly string _filePath;

        protected override Movie GetByNameCore ( string name )
        {
            var reader = new StreamReader (_filePath);
            try
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine ();
                    var movie = LoadMovie (line);
                    if (String.Compare (movie?.Title, name, true) == 0)
                        return movie;
                };
            } finally
            {
                //reader.Dispose();
                reader.Close ();
            };

            return null;
        }

        protected override Movie GetCore ( int id )
        {
            //Hard way
            //var stream = File.OpenRead(_filePath);            
            //stream.Read()

            //Reader way            
            using (var reader = new StreamReader (_filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine ();
                    var movie = LoadMovie (line);
                    if (movie?.Id == id)
                        return movie;
                };
            };
            return null;
        }

        protected override void RemoveCore ( int id )
        {
            var movies = GetAllCore ()
                                .Where (m => m.Id != id);

            SaveMovies (movies);
        }

        protected override Movie UpdateCore ( int id, Movie newMovie )
        {
            var movies = GetAllCore ()
                                .Where (m => m.Id != id);

            newMovie.Id = id;
            movies = movies.Union (new[] { newMovie });

            SaveMovies (movies);
            return newMovie;
        }

        private void SaveMovies ( IEnumerable<Movie> items )
        {
            var lines = items.Select (i => SaveMovie (i)).ToArray ();
            File.WriteAllLines (_filePath, lines);
        }

        private Movie LoadMovie ( string line )
        {
            if (String.IsNullOrEmpty (line))
                return null;

            var tokens = line.Split (',');
            if (tokens.Length != 7)
                return null;

            return new Movie () {
                Id = Int32.TryParse (tokens[0], out var id) ? id : 0,
                Title = tokens[1].Trim ('"', ' '),
                Description = tokens[2].Trim ('"', ' '),
                Rating = tokens[3].Trim ('"', ' '),
                ReleaseYear = Int32.TryParse (tokens[4], out var year) ? year : 1900,
                RunLength = Int32.TryParse (tokens[5], out var length) ? length : 0,
                HasSeen = Boolean.TryParse (tokens[6], out var seen) ? seen : false,
            };
        }

        private string SaveMovie ( Movie item )
        {
            //Field,Field2,...
            return $"{item.Id},\"{item.Title}\",\"{item.Description}\",{item.Rating},{item.ReleaseYear},{item.RunLength},{item.HasSeen}";
        }
    }
}
