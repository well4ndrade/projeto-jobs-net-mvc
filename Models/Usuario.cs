using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace projeto_jobs_net_mvc.Models
{
  public record Usuario
  {
    public int Id { get;set; }
    public string Nome { get;set; }
    public string Cpf { get;set; }
    public string Rg { get;set; }
    public string Genero { get;set; }
    public DateTime Nascimento { get;set; }
    public string Telefone { get;set; }
    public string Telefone2 { get;set; }
    public string Email { get;set; }
    public string Profissao { get;set; }
    public string EstadoCivil { get;set; }
    public string PossuiVeiculo { get;set; }
    public string PossuiHabilitacao { get;set; }
    public int endereco_id { get; set; }
  }
}