using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        //[Range(0,25)]
        public string Notes { get; set; }

        //Rating (dropdown menu (G, PG, PG-13, R)
        //    Edited (Boolean) = bool
        //    Notes ( max 25 char)
    }
}
