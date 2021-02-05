using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Database
{
    public partial class Zaposlenici
    {
        public Zaposlenici()
        {
            ZaposleniciDogadjaji = new HashSet<ZaposleniciDogadjaji>();
        }

        public short Id { get; set; }
        public string Sifra { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public byte? Pol { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public DateTime? DatumDodavanja { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual ICollection<ZaposleniciDogadjaji> ZaposleniciDogadjaji { get; set; }
    }
}
