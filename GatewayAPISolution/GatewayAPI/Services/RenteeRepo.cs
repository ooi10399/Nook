using GatewayAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI.Services
{
    public class RenteeRepo : IRepo<int, Rentee>
    {
        private readonly HttpClient _httpClient;

        public RenteeRepo()
        {
            _httpClient = new HttpClient();

        }
        public async Task<Rentee> Add(Rentee item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:54210/api/Rentee", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Rentee>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<Rentee> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:54210/api/Rentee?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Rentee>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<Rentee> Get(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:54210/api/Rentee/SingleEmployee?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Rentee>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Rentee>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:54210/api/Rentee"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var rens = JsonConvert.DeserializeObject<List<Rentee>>(responseText);
                        return rens.ToList();
                    }
                }
            }
            return null;
        }

        public async Task<Rentee> Update(Rentee item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:54210/api/Rentee?id=" + item.UserId, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Rentee>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }
    }
}
