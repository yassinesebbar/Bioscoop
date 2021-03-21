using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Bioscoop.Data;

namespace Bioscoop.Models
{
    public class TicketDiscount
    {
        [Key]
        public int ID {get;set;}

        public String description {get; set;}

        public Double discountAmount {get; set;}
    }
}
