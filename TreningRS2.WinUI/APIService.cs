using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningRS2.Models;
namespace TreningRS2.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
        {
            
                var url = $"{ Properties.Settings.Default.APIUrl}/{_route}";
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
           
        }
        public async Task<T> GetById<T>(object id)
        {
            //svaka asinhrona mora vracat task i mora da awaita externe resurse

            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}/{id}";
            
           return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            
        }
        public async Task<T> Insert<T>(object insert)
        {

            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PostJsonAsync(insert).ReceiveJson<T>();
            //return await url.PostJsonAsync(insert).ReceiveJson<T>();


        }
        //vratit na int id
        public async Task<T> Update<T>(object id,object update)
        {
          

            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}/{id}";

           return await url.WithBasicAuth(Username, Password).PostJsonAsync(update).ReceiveJson<T>();
           // return await url.PutJsonAsync(update).ReceiveJson<T>();


        }
    }
}
