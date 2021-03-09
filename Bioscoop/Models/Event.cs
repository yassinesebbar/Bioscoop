using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;
using System.Collections.Generic;

namespace Bioscoop.Models
{
    public class Event
    {
        [Key]
        public int ID {get; set;}

        public int IDhall{get; set;}
        [Required]
        public Hall Hall {get; set;}

        public DateTime Start {get; set;}

        public DateTime End {get; set;}

        public int IDmovie {get; set;}
        [Required]
        public Movie Movie {get; set;}

        private List<String> ReservedSeats {get; set;}

        private List<String> AvailableSeats {get; set;}


        public void setHallInformation(){
            if(Hall != null){
                this.AvailableSeats = Hall.getSeats();
            }
         }
    }
}