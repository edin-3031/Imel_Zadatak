
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
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
    public class ZaposleniciController : ControllerBase
    {
        private readonly IZaposleniciService service_Zaposlenici;

        public ZaposleniciController(IZaposleniciService _service_Zaposlenici)
        {
            service_Zaposlenici = _service_Zaposlenici;

        }

        [HttpGet]
        public List<Models.zaposlenici> GetAll([FromQuery] ZaposleniciSearchRequest request)
        {
            return service_Zaposlenici.GetAll(request);
        }

        [HttpGet("{id}")]
        public Models.zaposlenici GetById(int id)
        {
            return service_Zaposlenici.GetById(id);
        }

        [HttpPost]
        public void InsertNew([FromBody]Models.zaposlenici novi)
        {
            service_Zaposlenici.InsertNew(novi);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service_Zaposlenici.Delete(id);
        }

        [HttpPut("{id}")]
        public Models.zaposlenici Edit(int id, Models.zaposlenici novi)
        {
            return service_Zaposlenici.Edit(id,novi);
        }
    }
}