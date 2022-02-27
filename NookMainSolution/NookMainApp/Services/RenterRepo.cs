using Newtonsoft.Json;
using NookMainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NookMainApp.Services
{
    public class RenterRepo : IRepo<string, Renter>
    {
        private readonly HttpClient _httpClient;
        private string _token;

        public RenterRepo()
        {
            _httpClient = new HttpClient();

        }

        public void GetToken(string token)
        {
            _token = token;
        }

        public async Task<Renter> Add(Renter item)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:47049/api/Renter", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Renter>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<Renter> Delete(string key)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:47049/api/Renter?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Renter>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }

        public async Task<Renter> Get(string key)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Renter/GetRenter?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Renter>(responseText);
                        return ren;
                    }
                }
            }
          
            return null;
        }

        public async Task<IEnumerable<Renter>> GetAll()
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Renter/GetAllRenters"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var rens = JsonConvert.DeserializeObject<List<Renter>>(responseText);
                        return rens.ToList();
                    }
                }
            }
            return null;
        }

        public async Task<Renter> Update(Renter item)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:47049/api/Renter?id=" + item.UserId, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var ren = JsonConvert.DeserializeObject<Renter>(responseText);
                        return ren;
                    }
                }
            }
            return null;
        }
    }
}
