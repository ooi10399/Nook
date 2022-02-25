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
    public class RenterRepo : IRepo<string, RenterDTO>
    {
        private readonly HttpClient _httpClient;

        public RenterRepo()
        {
            _httpClient = new HttpClient();

        }
        public async Task<RenterDTO> Add(RenterDTO item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:24324/api/Renter", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenterDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<RenterDTO> Delete(string key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:24324/api/Renter?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenterDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<RenterDTO> Get(string key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:24324/api/Renter/SingleUser?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenterDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<RenterDTO>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:24324/api/Renter"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var rens = JsonConvert.DeserializeObject<List<RenterDTO>>(responseText);
                        return rens.ToList();
                    }
                }
            }
            return null;
        }

        public async Task<RenterDTO> Update(RenterDTO item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:24324/api/Renter?id=" + item.UserId, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<RenterDTO>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }
    }
}
