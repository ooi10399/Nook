using Newtonsoft.Json;
using NookMainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NookMainApp.Services
{
    public class AppointmentRepo : IRepo<int, Appointment>, ISingleUserRepo<string, Appointment>
    {
        private readonly HttpClient _httpClient;
        private string _token;

        public AppointmentRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Appointment> Add(Appointment item)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:47049/api/Appointment", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appt = JsonConvert.DeserializeObject<Appointment>(responseText);
                        return appt;
                    }
                }
            }
            return null;
        }

        public async Task<Appointment> Delete(int key)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:47049/api/Appointment?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appt = JsonConvert.DeserializeObject<Appointment>(responseText);
                        return appt;
                    }
                }
            }
            return null;
        }

        public async Task<Appointment> Get(int key)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment/SingleAppointment?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointment = JsonConvert.DeserializeObject<Appointment>(responseText);
                        return appointment;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Appointment>> GetAll(string userEmail)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token); 
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment?userName=" + userEmail))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointments = JsonConvert.DeserializeObject<List<Appointment>>(responseText);
                        return appointments;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointments = JsonConvert.DeserializeObject<List<Appointment>>(responseText);
                        return appointments;
                    }
                }
            }
            return null;
        }

        public void GetToken(string token)
        {
            _token = token;
        }

        public async Task<Appointment> Update(Appointment item)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            using (_httpClient)
            {
                using (var response = await _httpClient.PutAsJsonAsync("http://localhost:11278/api/Appointment?id=" + item.AppointmentId, item))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointment = JsonConvert.DeserializeObject<Appointment>(responseText);
                        return appointment;
                    }
                }
            }
            return null;
        }
    }
}
