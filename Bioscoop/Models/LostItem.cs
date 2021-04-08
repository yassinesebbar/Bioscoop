using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioscoop.Models
{
    public class LostItem
    {
        public int ID {get; set;}
        public String Description { get; set; }
        public DateTime DateLost { get; set; }
        public DateTime DateFound { get; set;}
        public String EmployeeFound { get; set; }
        public String EmployeeRelease { get; set; }
        public String Image { get; set; }
        public String LocationFound { get; set; }
        public Boolean ItemFound { get; set; }


        public LostItem()
        {
            this.DateLost = DateTime.Now;
            this.ItemFound = false;
        }

    }
}
