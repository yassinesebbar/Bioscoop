using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Bioscoop.Models
{
    public class Chair
    {

        [Key]
        public int ID {get; set;}

        [AllowNull] 
        public int? FKIDHall {get; set;}

        [AllowNull]
        public int? FKIDEventReserverd {get; set;}

        [AllowNull]
        public int? FKIDEventAvailable {get; set;}

        [AllowNull]
        public int? FKIDReservation {get; set;}

        public String ChairNr {get; set;}
    }
}
