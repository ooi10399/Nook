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
        private HttpClientHandler _httpClientHandler;

        public AppointmentRepo()
        {
            _httpClientHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpClientHandler, false);

        }
        public async Task<Appointment> Add(Appointment item)
        {
            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            //HttpClientHandler handler = new HttpClientHandler();
            //StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
            //using (var response = await new HttpClient(handler, false).PostAsync("http://localhost:47049/api/Appointment", content))
            //{
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string responseText = await response.Content.ReadAsStringAsync();
            //        var appt = JsonConvert.DeserializeObject<Appointment>(responseText);
            //        return appt;
            //    }
            //}
            //return null;

            HttpClientHandler handler = new HttpClientHandler();
            HttpClient _httpClient = new HttpClient(handler, false);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
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
            return null;
        }

        public async Task<Appointment> Delete(int key)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient _httpClient = new HttpClient(handler, false);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (var response = await _httpClient.DeleteAsync("http://localhost:47049/api/Appointment?id=" + key))
            {
                if (response.IsSuccessStatusCode)
                {
                    string responseText = await response.Content.ReadAsStringAsync();
                    var appt = JsonConvert.DeserializeObject<Appointment>(responseText);
                    return appt;
                }
            }
            return null;

            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            //HttpClientHandler handler = new HttpClientHandler();
            //using (var response = await new HttpClient(handler,false).DeleteAsync("http://localhost:47049/api/Appointment?id=" + key))
            //{
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string responseText = await response.Content.ReadAsStringAsync();
            //        var appt = JsonConvert.DeserializeObject<Appointment>(responseText);
            //        return appt;
            //    }
            //}
            //return null;
        }

        public async Task<Appointment> Get(int key)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient _httpClient = new HttpClient(handler, false);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment/GetAppointment?id=" + key))
            {
                if (response.IsSuccessStatusCode)
                {
                    string responseText = await response.Content.ReadAsStringAsync();
                    var appointment = JsonConvert.DeserializeObject<Appointment>(responseText);
                    return appointment;
                }
            }
            return null;

            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            //HttpClientHandler handler = new HttpClientHandler();
            //using (var response = await new HttpClient(handler,false).GetAsync("http://localhost:47049/api/Appointment/GetAppointment?id=" + key))
            //{
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string responseText = await response.Content.ReadAsStringAsync();
            //        var appointment = JsonConvert.DeserializeObject<Appointment>(responseText);
            //        return appointment;
            //    }
            //}
            //return null;
        }

        public async Task<IEnumerable<Appointment>> GetAll(string userEmail)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient _httpClient = new HttpClient(handler, false);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment/GetUserAppointments?userName=" + userEmail))
            {
                if (response.IsSuccessStatusCode)
                {
                    string responseText = await response.Content.ReadAsStringAsync();
                    var appointments = JsonConvert.DeserializeObject<List<Appointment>>(responseText);
                    return appointments;
                }
            }
            return null;         
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient _httpClient = new HttpClient(handler, false);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment/GetAllAppointments"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string responseText = await response.Content.ReadAsStringAsync();
                    var appointments = JsonConvert.DeserializeObject<List<Appointment>>(responseText);
                    return appointments;
                }
            }
            
            return null;

            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            //using (_httpClient)
            //{
            //    using (var response = await _httpClient.GetAsync("http://localhost:47049/api/Appointment/GetAllAppointments"))
            //    {
            //        if (response.IsSuccessStatusCode)
            //        {
            //            string responseText = await response.Content.ReadAsStringAsync();
            //            var appointments = JsonConvert.DeserializeObject<List<Appointment>>(responseText);
            //            return appointments;
            //        }
            //    }
            //}
            //return null;
        }

        public void GetToken(string token)
        {
            _token = token;
        }

        public async Task<Appointment> Update(Appointment item)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient _httpClient = new HttpClient(handler, false);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            using (var response = _httpClient)
            {
                var result = await response.PutAsJsonAsync("http://localhost:47049/api/Appointment?id=" + item.AppointmentId, item);
                if (result.IsSuccessStatusCode)
                {
                    string responseText = await result.Content.ReadAsStringAsync();
                    var appointment = JsonConvert.DeserializeObject<Appointment>(responseText);
                    return appointment;
                }
            }
            return null;

            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);       

            //HttpClientHandler handler = new HttpClientHandler();
            //using (var response = new HttpClient(handler, false))
            //{
            //    var result = await response.PutAsJsonAsync("http://localhost:47049/api/Appointment?id=" + item.AppointmentId, item);
            //    if (result.IsSuccessStatusCode)
            //    {
            //        string responseText = await result.Content.ReadAsStringAsync();
            //        var appointment = JsonConvert.DeserializeObject<Appointment>(responseText);
            //        return appointment;
            //    }
            //}
            //return null;
        }
    }
}
