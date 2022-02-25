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
    public class RenteeRepo : IRepo<string, Rentee>
    {
        private readonly HttpClient _httpClient;
        private string _token;

        public RenteeRepo()
        {
            _httpClient = new HttpClient();

        }

        public void GetToken(string token)
        {
            _token = token;
        }

        public async Task<Rentee> Add(Rentee item)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:47049/api/Rentee", content))
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

        public async Task<Rentee> Delete(string key)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:47049/api/Rentee?id=" + key))
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

        public async Task<Rentee> Get(string key)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Rentee/GetRentee?id=" + key))
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
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Rentee/GetAllRentees"))
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
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:47049/api/Rentee?id=" + item.UserId, content))
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
