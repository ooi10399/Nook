using Newtonsoft.Json;
using NookMainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NookMainApp.Services
{
    public class LoginService
    {
        private readonly HttpClient _httpClient;

        public LoginService()
        {
            _httpClient = new HttpClient();

        }

        public async Task<User> Register(User user)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:47049/api/User/Register", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var usr = JsonConvert.DeserializeObject<User>(responseText);
                        return usr;
                    }
                }
            }
            return null;
        }

        public async Task<User> Login(User user)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:47049/api/User/Login", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var usr = JsonConvert.DeserializeObject<User>(responseText);
                        return usr;
                    }
                }
            }
            return null;
        }
    }
}
