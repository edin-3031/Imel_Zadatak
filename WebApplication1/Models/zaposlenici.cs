using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class zaposlenici
    {
        public int Id { get; set; }
        public string Sifra { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public byte? Pol { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public DateTime? DatumDodavanja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}
