using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public double SaleAmt { get; set; }
        public int ClientID { get; set; }
        public int InstrumentID { get; set; }
    }
}