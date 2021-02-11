using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class dogadjaji
    {
        public short Id { get; set; }
        public short? ZaposleniciId { get; set; }
        public DateTime? Datum { get; set; }
        public string TekstDogadjaja { get; set; }
    }
}
