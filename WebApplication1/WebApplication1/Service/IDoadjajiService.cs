using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;

namespace WebApplication1.Service
{
    public interface IDoadjajiService
    {
        public List<ZaposleniciDogadjaji> Get(int id);
        public Models.dogadjaji Insert(int id, Models.dogadjaji novi);
        public ZaposleniciDogadjaji Edit(int id, Models.dogadjaji novi);
        public void Delete(int id);
        
    }
}
