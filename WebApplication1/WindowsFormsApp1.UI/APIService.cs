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

        public async Task<T> GetById<T>(object id2)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}/{id2}";

            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task InsertNew<T>(object novi)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}";

            await url.PostJsonAsync(novi).ReceiveJson<T>();
        }

        public async Task InsertNewDogadjaj<T>(object novi)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}";

            await url.PostJsonAsync(novi);
        }

        public async Task<T> Update<T>(object id, object postojeci)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}/{id}";

            return await url.PutJsonAsync(postojeci).ReceiveJson<T>(); ;
        }

        public async void Delete(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{route}/{id}";

            await url.DeleteAsync();
        }
    }
}