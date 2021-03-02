using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bioscoop.Models
{
    public class Movie
    {
        public int ID {get; set;}
        
        [Display(Name = "Releasedatum")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}

        [Display(Name = "Afbeelding")]
        public String ImageCover {get; set;}


        [Display(Name = "Titel")]
        public string Title {get; set;}


        [Display(Name = "Omschrijving")]
        public string Description {get; set;}

        [Display(Name = "Genre")]
        public string Genre {get; set;}

        [Display(Name = "Kijkwijzer")]
        public string RatingGuide {get; set;}

        [Display(Name = "Regisseur")]
        public string director {get; set;} 

        [Display(Name = "Cast")]

        public string Cast {get; set;}

        [Display(Name = "Duur")]
        public int DurationMin {get; set;}

        [Display(Name = "Prijs")]
        public decimal Price {get; set;}

    }
}