using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioscoop.ViewDataWrapper
{
    public class NonPersistantLostItems
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public DateTime DateLost { get; set; }
        public String EmployeeFound { get; set; }
        public String LocationFound { get; set; }
        public Boolean ItemFound { get; set; }
        public IFormFile ImageLostItem { get; set; }
    }
}
