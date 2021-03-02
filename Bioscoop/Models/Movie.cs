using System;
using System.ComponentModel.DataAnnotations;

namespace Bioscoop.Models
{
    public class Movie
    {
        public int ID {get; set;}
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}

        public String ImageCover {get; set;}

        public string Title {get; set;}

        public string Description {get; set;}

        public string Genre {get; set;}

        public string RatingGuide {get; set;}

        public string director {get; set;} 

        public string Cast {get; set;}

        public int DurationMin {get; set;}
        public decimal Price {get; set;}
    }
}