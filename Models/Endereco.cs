using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_jobs_net_mvc.Models
{
  public record Endereco
  {
    public int Id { get;set; }
    public string Cep { get;set; }
    public string Logradouro { get;set; }
    public int Numero { get;set; }
    public string Bairro { get;set; }
    public string Cidade { get;set; }
    public string Estado { get;set; }
    public string Pais { get;set; }
    
    // Verificar a necessidade do item abaixo depois:
    public ICollection<Usuario> Usuario { get; set; }
}
}