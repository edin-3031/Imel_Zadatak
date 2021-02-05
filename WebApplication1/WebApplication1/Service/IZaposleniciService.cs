using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;

namespace WebApplication1.Service
{
    public interface IZaposleniciService
    {
        public List<Zaposlenici> GetAll();
        public Zaposlenici Insert(Models.zaposlenici novi);
        public Models.zaposlenici Edit(int id, Models.zaposlenici novi);
        public void Delete(int id);
    }
}
