using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;

namespace WebApplication1.Service
{
    public class DoadjajiService : IDoadjajiService
    {
        private readonly MyDBTEstContext db;
        private readonly IMapper mapper;

        public DoadjajiService(MyDBTEstContext _db, IMapper _mapper)
        {
            db = _db;
            mapper = _mapper;
        }

        public void Delete(int id)
        {
            ZaposleniciDogadjaji temp = db.ZaposleniciDogadjaji.Where(a => a.Id == id).FirstOrDefault();

            if (temp != null)
            {
                db.Remove(temp);
                db.SaveChanges();
            }
        }

        public Database.ZaposleniciDogadjaji Edit(int id, Models.dogadjaji novi)
        {
            ZaposleniciDogadjaji temp = db.ZaposleniciDogadjaji.Where(a => a.Id == id).FirstOrDefault();

            temp.Datum = novi.Datum;
            temp.TekstDogadjaja = novi.TekstDogadjaja;
            temp.Id = (short)id;

            db.SaveChanges();

            return temp;
        }

        public List<ZaposleniciDogadjaji> Get(int id)
        {
            return db.ZaposleniciDogadjaji.Where(a => a.ZaposleniciId == id).ToList();
        }

        public Models.dogadjaji Insert(int id, Models.dogadjaji novi)
        {
            Database.ZaposleniciDogadjaji temp = mapper.Map<ZaposleniciDogadjaji>(novi);
            db.Add(temp);
            db.SaveChanges();
            return novi;
        }
    }
}