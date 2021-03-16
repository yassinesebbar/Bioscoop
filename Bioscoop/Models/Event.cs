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

        public void setBasePrijs(Double BasePrijs)
        {
            if(this.Movie.ThreeD){
                this.BasePrijs += 2.5;
            }

            if(this.Movie.DurationMin > 119){
                this.BasePrijs += 8.50;
            }

            this.BasePrijs += BasePrijs;
        }
        public List<Chair> getReservedSeats()
        {
            return this.ReservedSeats;
        }

        public void setReservedSeats(List<Chair> ReservedSeats)
        {
            this.ReservedSeats = ReservedSeats;
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
                this.AvailableSeats = Hall.getSeats();
            }

            foreach(Chair seat in this.AvailableSeats){
                db.Update(seat);
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