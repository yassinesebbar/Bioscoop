using System;
using Bioscoop.Models;
using System.Collections.Generic;
using Bioscoop.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bioscoop.Models
{
    public class Payment
    {
        [Key]
        public int ID {get; set;}
        public PaymentMethod paymentMethod {get; set;}
        public String Banknr {get; set;}
        public Double Amount {get; set;}
        public String CouponCode {get; set;}
        public Reservation reservation {get; set;}
    }
}
