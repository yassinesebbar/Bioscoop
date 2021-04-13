using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;
using Bioscoop.Data;


namespace Bioscoop.Models
{
    public class Hall
    {

        public String Name{get; set;}

        [Key]
        public int ID {get; set;}
        public String Description {get; set;}
        public int Rows {get; set;}
        
        public int SeatsPerRow {get; set;}
        public int NumSeats{get; set;}

        [ForeignKey("FKIDHall")]
        public virtual List<Chair> Seats { get; set; }

        public virtual List<Chair> getSeats()
        {
            return this.Seats;
        }

        public void CalculateSeats()
        {
            NumSeats = SeatsPerRow * Rows;
        }

        public void SetSeats(BioscoopContext db, Event ev)
        {  
            ev.AvailableSeats = new List<Chair>();

              if(SeatsPerRow != 0 && Rows != 0)
            {
                String[] alphabet = new String[] {"A", "B","C","D","E","F","G","H","I","J","K","L","M","N","O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
                Seats = new List<Chair>();

                for (int row = 0; row < Rows; row++) 
                {
                    for (int seat = 1; seat <= SeatsPerRow; seat++) 
                    {
                       Chair objSeat = new Chair();
                       objSeat.ChairNr = alphabet[row] + seat;

                        this.Seats.Add(objSeat);
                        ev.AvailableSeats.Add(objSeat);
                        db.Add(objSeat);
                    }
                }
            }
        }
    }



}