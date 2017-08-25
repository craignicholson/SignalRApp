using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignalRRealTimeSQL
{
    public class Products
    {
        public string WebService { get; set; }
        public string Method { get; set; }
        public DateTime TimeReceived { get; set; }
        public string TransactionID { get; set; }
        public string Note { get; set; }
        public string RequestXML { get; set; }

    }
}
