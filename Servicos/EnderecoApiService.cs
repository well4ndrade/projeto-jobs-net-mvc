using projeto_jobs_net_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace projeto_jobs_net_mvc.Servicos
{
    public class EnderecoApiService
  {
    public static async Task<List<Endereco>> GetEnderecos()
    {
        HttpClient http = new HttpClient();
        var response = await http.GetAsync($"{Program.ApiHost}/enderecos");
        if(response.IsSuccessStatusCode)
        {
            var resultado = response.Content.ReadAsStringAsync().Result;
            var enderecos = JsonConvert.DeserializeObject<List<Endereco>>(resultado);
            return enderecos;
        }

        return new List<Endereco>();
    }
  }
  
}