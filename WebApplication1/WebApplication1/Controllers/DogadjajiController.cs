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
        public List<ZaposleniciDogadjaji> GetAll(int id)
        {
            return service_dogadjaj.Get(id);
        }

        [HttpPost("{id}")]
        public Models.dogadjaji Insert(int id, Models.dogadjaji novi)
        {
            return service_dogadjaj.Insert(id,novi);
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