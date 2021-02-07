using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using Models;
using WebApp.Models;

namespace WindowsFormsApp1.UI
{
    public class APIService
    {
        private string route = null;

        public APIService(string _route)
        {
            route = _route;
        }

        public async Task<T> Get<T>(object search)
        {


            var url = $"{Properties.Settings.Default.APIUrl}/{route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>();

            return result;
        }
    }
}
