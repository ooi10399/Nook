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
    public class RenteeRepo : IRepo<string, RenteeDTO>
    {
        private readonly HttpClient _httpClient;

        public RenteeRepo()
        {
            _httpClient = new HttpClient();

        }
        public async Task<RenteeDTO> Add(RenteeDTO item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:24324/api/Rentee", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenteeDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<RenteeDTO> Delete(string key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:24324/api/Rentee?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenteeDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<RenteeDTO> Get(string key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:24324/api/Rentee/SingleUser?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenteeDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<RenteeDTO>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:24324/api/Rentee"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var rens = JsonConvert.DeserializeObject<List<RenteeDTO>>(responseText);
                        return rens.ToList();
                    }
                }
            }
            return null;
        }

        public async Task<RenteeDTO> Update(RenteeDTO item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:24324/api/Rentee?id=" + item.UserId, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenteeDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }
    }
}
