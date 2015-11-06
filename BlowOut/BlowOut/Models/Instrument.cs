using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int InstrumentID { get; set; }
        public string instName { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public string condition { get; set; }
        public int? ClientID { get; set; }
        public string pic { get; set; }
    }


}