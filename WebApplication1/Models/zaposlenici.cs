using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class zaposlenici
    {
        [Required]
        public string Sifra { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public byte? Pol { get; set; }
        [Required]
        public string Grad { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public DateTime? DatumDodavanja { get; set; }
        [Required]
        public DateTime? DatumIzmjene { get; set; }
    }
}
