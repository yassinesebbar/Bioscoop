using System;

namespace Bioscoop.Models
{
    public class FinanceTransaction
    {
        public int ID { get; set; }
        public Double basePrice { get; set; }
        public Double ExtraTarif { get; set; }
        public String descriptionExtraTarif { get; set; }
        public Double discount { get; set; }
        public TicketDiscount Discount { get; set; }
        public Double totalPrice { get; set; }
        public DateTime DateTimeTransaction { get; set; }
        public int IDdiscount {get; set;}

        public int getID()
        {
            return this.ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public Double getBasePrice()
        {
            return this.basePrice;
        }

        public void setBasePrice(Double basePrice)
        {
            this.basePrice = basePrice;
        }

        public Double getExtraTarif()
        {
            return this.ExtraTarif;
        }

        public void setExtraTarif(int ExtraTarif)
        {
            this.ExtraTarif = ExtraTarif;
        }

        public String getDescriptionExtraTarif()
        {
            return this.descriptionExtraTarif;
        }

        public void setDescriptionExtraTarif(String descriptionExtraTarif)
        {
            this.descriptionExtraTarif = descriptionExtraTarif;
        }

        public Double getDiscount()
        {
            return this.discount;
        }

        public void setDiscount(TicketDiscount discount)
        {
            this.Discount = discount;
            this.discount = this.Discount.discountAmount;
        }

        public Double getTotalPrice()
        {
            return this.totalPrice;
        }

        public void setTotalPrice()
        {
                 this.totalPrice = totalPrice - discount;
        }

        public DateTime getDateTimeTransaction()
        {
            return this.DateTimeTransaction;
        }

        public void setDateTimeTransaction(DateTime DateTimeTransaction)
        {
            this.DateTimeTransaction = DateTimeTransaction;
        }
    }
}
