using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Zaposlenici, Models.zaposlenici>().ReverseMap();
            CreateMap<Models.dogadjaji, Database.ZaposleniciDogadjaji>().ReverseMap();
            CreateMap<List<Models.dogadjaji>, List<Database.ZaposleniciDogadjaji>>().ReverseMap();
        }
    }
}
