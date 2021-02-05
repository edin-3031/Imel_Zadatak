using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;

namespace WebApplication1.Service
{
    public class ZaposleniciService : IZaposleniciService
    {
        private readonly MyDBTEstContext db;
        private readonly IMapper mapper; 

        public ZaposleniciService(MyDBTEstContext _db, IMapper _mapper)
        {
            db = _db;
            mapper = _mapper;
        }

        public void Delete(int id)
        {
            Zaposlenici temp = db.Zaposlenici.Where(a => a.Id == id).FirstOrDefault();

            if (temp != null)
            {
                foreach (var x in db.ZaposleniciDogadjaji)
                {
                    if (x.ZaposleniciId == id)
                    {
                        db.Remove(x);
                    }
                }

                db.Remove(temp);
                db.SaveChanges();
            }
        }

        public Models.zaposlenici Edit(int id, Models.zaposlenici novi)
        {
            Database.Zaposlenici temp = db.Zaposlenici.Where(a => a.Id == id).FirstOrDefault();
            
            if (temp != null)
            {
                temp.Grad = novi.Grad;
                temp.Adresa = novi.Adresa;
                temp.DatumDodavanja = novi.DatumDodavanja;
                temp.DatumIzmjene = novi.DatumIzmjene;
                temp.Pol = novi.Pol;
                temp.Ime = novi.Ime;
                temp.Prezime = novi.Prezime;
                temp.Sifra = novi.Sifra;

                db.SaveChanges();
            }

            return novi;
        }

        public List<Zaposlenici> GetAll()
        {
            return db.Zaposlenici.ToList();
        }

        public Zaposlenici Insert(Models.zaposlenici novi)
        {
            Zaposlenici temp=mapper.Map<Zaposlenici>(novi);

            db.Add(temp);
            db.SaveChanges();

            return temp;
        }
    }
}