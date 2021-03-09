using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;

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
        private int NumSeats{get; set;}
        private List<String> Seats { get; set; }

        public List<String> getSeats()
        {
            return this.Seats;
        }

        public void SetSeats()
        {   
              if(SeatsPerRow != 0 && Rows != 0)
            {
                NumSeats = SeatsPerRow * Rows;
                String[] alphabet = new String[] {"A", "B","C","D","E","F","G","H","I","J","K","L","M","N","O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
                Seats = new List<string>();

                for (int row = 0; row <= Rows; row++) 
                {
                    for (int seat = 0; seat <= SeatsPerRow; seat++) 
                    {
                        Seats.Add(alphabet[row] + seat);
                    }
                }
            }
        }
    }



}