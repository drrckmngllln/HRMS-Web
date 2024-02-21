using HrmsPrototype.Infrastructure.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HrmsPrototype.Infrastructure.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private const string baseUrl = "https://localhost:5001/api/";
        HttpClient http = new HttpClient();

        public async Task AddAsync(T entity, string url)
        {
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await http.PostAsync(baseUrl + url, content);
        }

        public async Task DeleteAsync(string url)
        {
            var response = await http.DeleteAsync(baseUrl + url);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(string url)
        {
            var response = await http.GetAsync(baseUrl + url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<List<T>>(content);
                return json;
            }
            return null;
        }

        public async Task UpdateAsync(T entity, string url)
        {
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await http.PutAsync(baseUrl + url, content);
        }
    }
}
