using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogadjajiController : ControllerBase
    {
        private readonly IDoadjajiService service_dogadjaj;

        public DogadjajiController(IDoadjajiService _service_dogadjaj)
        {
            service_dogadjaj = _service_dogadjaj;
        }

        [HttpGet("{id}")]
        public List<Models.dogadjaji> GetById(int id)
        {
            return service_dogadjaj.Get(id);
        }

        //[HttpGet("{id2}")]
        //public Models.dogadjaji Get(int id)
        //{
        //    return service_dogadjaj.getByIdDogadjaj(id, true);
        //}

        [HttpPost]
        public void Insert([FromBody]Models.dogadjaji novi)
        {
            service_dogadjaj.Insert(novi);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service_dogadjaj.Delete(id);
        }

        [HttpPut("{id}")]
        public Database.ZaposleniciDogadjaji Edit(int id, Models.dogadjaji izmjene)
        {
            return service_dogadjaj.Edit(id, izmjene);
        }
    }
}