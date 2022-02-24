using GatewayAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GatewayAPI.Services
{
    public class AppointmentRepo : IRepo<int, AppointmentDTO>, ISingleUserRepo<string, AppointmentDTO>
    {
        private readonly HttpClient _httpClient;
        public AppointmentRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<AppointmentDTO> Add(AppointmentDTO item)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.PostAsJsonAsync("http://localhost:11278/api/Appointment", item))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointment = JsonConvert.DeserializeObject<AppointmentDTO>(responseText);
                        return appointment;
                    }
                }
            }
            return null;
        }

        public async Task<AppointmentDTO> Delete(int key)
        {
            using(_httpClient)
            {
                using(var response = await _httpClient.DeleteAsync("http://localhost:11278/api/Appointment?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointment = JsonConvert.DeserializeObject<AppointmentDTO>(responseText);
                        return appointment;
                    }
                }
            }
            return null;
        }

        public async Task<AppointmentDTO> Get(int key)
        {
            using (_httpClient)
            {
                using(var response = await _httpClient.GetAsync("http://localhost:11278/api/Appointment/SingleAppointment?id=" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointment = JsonConvert.DeserializeObject<AppointmentDTO>(responseText);
                        return appointment;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<AppointmentDTO>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:11278/api/Appointment"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointments = JsonConvert.DeserializeObject<List<AppointmentDTO>>(responseText);
                        return appointments;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<AppointmentDTO>> GetAll(string userName)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:11278/api/Appointment?userName=" + userName))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointments = JsonConvert.DeserializeObject<List<AppointmentDTO>>(responseText);
                        return appointments;
                    }
                }
            }
            return null;
        }

        public async Task<AppointmentDTO> Update(AppointmentDTO item)
        {
            using(_httpClient)
            {
                using (var response = await _httpClient.PutAsJsonAsync("http://localhost:11278/api/Appointment?id=" + item.AppointmentId, item))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var appointment = JsonConvert.DeserializeObject<AppointmentDTO>(responseText);
                        return appointment;
                    }
                }
            }
            return null;
        }
    }
}
