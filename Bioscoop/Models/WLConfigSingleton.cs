using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bioscoop.Models;

namespace Bioscoop.Models
{
    public class WLConfigSingleton
    {
        public int ID { get; set; }
        public bool WhiteListing { get; set; }
        public bool IPapproved;


        public void checkWhiteListing(WhiteListingIP ipObj)
        {
            if (this.WhiteListing)
            {
                if (@ipObj == null)
                {
                    IPapproved = false;
                }
                else
                {
                    IPapproved = true;
                }
            }
            else
            {
                IPapproved = true;

            }
        }
    }
}
