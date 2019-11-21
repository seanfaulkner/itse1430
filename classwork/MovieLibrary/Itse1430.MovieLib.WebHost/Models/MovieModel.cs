using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Itse1430.MovieLib.WebHost.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Rating { get; set; }

        [Display (Name = "Release Year")]
        [Range (1900, Int32.MaxValue, ErrorMessage = "Release year must be >= 1900")]
        public int ReleaseYear { get; set; } = 1900;

        [Range (0, Int32.MaxValue, ErrorMessage = "Run length must be >= 0")]
        public int RunLength { get; set; }

        public bool HasSeen { get; set; }
    }
}