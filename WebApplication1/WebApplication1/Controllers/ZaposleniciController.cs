﻿
using Microsoft.AspNetCore.Http;
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
    public class ZaposleniciController : ControllerBase
    {
        private readonly IZaposleniciService service_Zaposlenici;

        public ZaposleniciController(IZaposleniciService _service_Zaposlenici)
        {
            service_Zaposlenici = _service_Zaposlenici;

        } 

        [HttpGet]
        public List<Zaposlenici> GetAll()
        {
            return service_Zaposlenici.GetAll();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service_Zaposlenici.Delete(id);
        }

        [HttpPost("{novi}")]
        public Zaposlenici Insert (Models.zaposlenici novi)
        {
            return service_Zaposlenici.Insert(novi);
        }


        [HttpPut("{id}")]
        public Models.zaposlenici Edit(int id, Models.zaposlenici novi)
        {
            return service_Zaposlenici.Edit(id,novi);
        }
    }
}
