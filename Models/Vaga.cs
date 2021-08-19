using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_jobs_net_mvc.Models
{
  public record Vaga
  {
    public int Id { get;set; }
    public string Nome { get;set; }
    public string descricao { get;set; }
  }
}