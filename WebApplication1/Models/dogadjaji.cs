using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class dogadjaji
    {
        public short Id { get; set; }
        [Required]
        public short? ZaposleniciId { get; set; }
        [Required]
        public DateTime? Datum { get; set; }
        [Required]
        public string TekstDogadjaja { get; set; }
    }
}
