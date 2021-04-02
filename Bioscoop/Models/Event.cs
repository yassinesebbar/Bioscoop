using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;
using System.Collections.Generic;
using Bioscoop.Data;

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
        public virtual Movie Movie {get; set;}

        [ForeignKey("FKIDEventReserverd")]
        public virtual List<Chair> ReservedSeats { get; set; }

        [ForeignKey("FKIDEventAvailable")]
        public virtual List<Chair> AvailableSeats { get; set; }

        public Double BasePrijs { get; set; }


        public Double getBasePrijs()
        {
            return this.BasePrijs;
        }

        public void setBasePrijs()
        {
            if(this.Movie.ThreeD){
                this.BasePrijs += 2.5;
            }
            if(this.Movie.DurationMin <= 120){
                this.BasePrijs += 8.50;
            }else{
                this.BasePrijs += 9;
            }
        }
        public List<Chair> getReservedSeats()
        {
            return this.ReservedSeats;
        }

        public List<Chair> getAvailableSeats()
        {
            return this.AvailableSeats;
        }

        public void setAvailableSeats(List<Chair> AvailableSeats)
        {
            this.AvailableSeats = AvailableSeats;
        }

        public void setHallInformation(BioscoopContext db){
            if(Hall != null){
                Hall.SetSeats(db, this);
            }
         }

         public Chair getRandomChair(){
            var random = new Random();
            int index = random.Next(AvailableSeats.Count);
            Chair randomChair = AvailableSeats[index];
            return randomChair;
         }

         public Boolean reserveSeat(Chair seat, BioscoopContext db = null){
            if(AvailableSeats.Contains(seat)){
                AvailableSeats.Remove(seat);
                ReservedSeats.Add(seat);
            if(db != null){
                db.Update(seat);
            }
                return true;
            }

            return false;
         }
    }
}