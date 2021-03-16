using System.Transactions;
using System;
using Bioscoop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Bioscoop.Data;


namespace Bioscoop.Models
{
    public class Reservation
    {
        [Key]
        public int ID {get; set;}
        public FinanceTransaction FinanceTransaction { get; set; }
        public Event Event { get; set; }

        [ForeignKey("FKIDReservation")]
        public virtual Chair StoelNr { get; set; }
        public Boolean geanuleerd { get; set; }
        public DateTime ReservationDate { get; set; }
        public int IDtransaction { get; set; }
        public int IDevent { get; set; }
        public int IDdiscount { get; set; }
        public int getIDtransaction()
        {
            return this.IDtransaction;
        }

        public void setIDtransaction(int IDtransaction)
        {
            this.IDtransaction = IDtransaction;
        }

        public int getIDevent()
        {
            return this.IDevent;
        }

        public void setIDevent(int IDevent)
        {
            this.IDevent = IDevent;
        }

        public FinanceTransaction getFinanceTransaction()
        {
            return this.FinanceTransaction;
        }

        public void setFinanceTransaction(FinanceTransaction FinanceTransaction)
        {
            this.FinanceTransaction = FinanceTransaction;
        }

        public Event getEvent()
        {
            return this.Event;
        }

        public void setEvent(Event Event)
        {
            this.Event = Event;
        }

        public Chair getStoelNr()
        {
            return this.StoelNr;
        }

        public void setStoelNr()
        {
            this.StoelNr = Event.getRandomChair();
        }

        public Boolean getGeanuleerd()
        {
            return this.geanuleerd;
        }

        public void setGeanuleerd(Boolean geanuleerd)
        {
            this.geanuleerd = geanuleerd;
        }

        public DateTime getReservationDate()
        {
            return this.ReservationDate;
        }

        public void setReservationDate(DateTime ReservationDate)
        {
            this.ReservationDate = ReservationDate;
        }

         public void setReservation(Event SingleEvents, TicketDiscount SingleDiscount, FinanceTransaction SingleTransaction)
        {
            this.Event = SingleEvents;
            this.FinanceTransaction = SingleTransaction;
            this.FinanceTransaction.Discount = SingleDiscount;
            this.setTransaction();
            this.setStoelNr();
            this.Event.reserveSeat(this.StoelNr, null);
            this.setReservationDate(new DateTime());
        }

        public void setTransaction(){
                this.FinanceTransaction.setBasePrice(this.Event.getBasePrijs());
                this.FinanceTransaction.setDateTimeTransaction(new DateTime());

                this.FinanceTransaction.setBasePrice(this.Event.BasePrijs);
                this.FinanceTransaction.setTotalPrice();
        }
    }
}