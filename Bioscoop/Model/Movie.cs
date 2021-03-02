using System;
using System.ComponentModel.DataAnnotations;

namespace Bioscoop.Models
{
    public class Movie
    {
        public int ID {get; set;}
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        public string Title {get; set;}

        public string Genre {get; set;}

        public int DurationMN {get; set;}

        public string MovieIndicator {get; set;}

        public string Cast {get; set;}

        public decimal Price {get; set;}      
    }
}