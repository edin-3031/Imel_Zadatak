using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Database
{
    public partial class ZaposleniciDogadjaji
    {
        public short Id { get; set; }
        public short? ZaposleniciId { get; set; }
        public DateTime? Datum { get; set; }
        public string TekstDogadjaja { get; set; }

        public virtual Zaposlenici Zaposlenici { get; set; }
    }
}
