using projeto_jobs_net_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace projeto_jobs_net_mvc.Servicos
{
    public class VagaApiService
  {
    public static async Task<List<Vaga>> GetVagas()
    {
        HttpClient http = new HttpClient();
        var response = await http.GetAsync($"{Program.ApiHost}/vagas");
        if(response.IsSuccessStatusCode)
        {
            var resultado = response.Content.ReadAsStringAsync().Result;
            var vagas = JsonConvert.DeserializeObject<List<Vaga>>(resultado);
            return vagas;
        }

        return new List<Vaga>();
        
    }
  }
  
}