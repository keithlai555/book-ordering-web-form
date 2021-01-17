using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EOrder
    {
        public bool DbError { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerNumber { get; set; }
        public string OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public int RecordCount { get; set; }
    }
}
