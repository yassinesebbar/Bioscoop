using Bioscoop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioscoop.ViewDataWrapper
{



    public class WhiteListing
    {
        public List<WhiteListingIP> IPlist { get; set; }
        public WLConfigSingleton WLconfig { get; set; }
        public Boolean wlconfigbool { get; set; }
        public int wlconfigid { get; set; }
    }
}
