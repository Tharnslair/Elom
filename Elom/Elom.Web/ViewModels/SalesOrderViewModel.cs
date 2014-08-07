using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elom.Web.ViewModels
{
    public class SalesOrderViewModel
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PONumber { get; set; }

        // hmmm
        public string MessageToClient { get; set; }
    }
}