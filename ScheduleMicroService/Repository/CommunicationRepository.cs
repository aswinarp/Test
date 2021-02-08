using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ScheduleMicroService.Models;

namespace ScheduleMicroService.Repository
{
    public class CommunicationRepository:ICommunicationRepository
    {
        public List<Medicine> GetMedicineList(IConfiguration _config)
        {
            using(var client =new HttpClient())
            {
                client.BaseAddress = new Uri(_config["URL:MedicineStock"]);
                var responseTask = client.GetAsync("GetMedicine");
                responseTask.Wait();
                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    return JsonConvert.DeserializeObject<List<Medicine>>(readTask.Result);
                }
            }
            return null;
        }
    }
}
