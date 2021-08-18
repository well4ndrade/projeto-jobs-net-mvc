using projeto_jobs_net_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace projeto_jobs_net_mvc.Servicos
{
    public class UsuarioApiService
  {
    public static async Task<List<Usuario>> GetUsuarios()
    {
        HttpClient http = new HttpClient();
        var response = await http.GetAsync($"{Program.ApiHost}/usuarios");
        if(response.IsSuccessStatusCode)
        {
            var resultado = response.Content.ReadAsStringAsync().Result;
            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(resultado);
            return usuarios;
        }

        return new List<Usuario>();
    }
  }
  
}