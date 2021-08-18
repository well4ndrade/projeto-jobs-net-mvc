using projeto_jobs_net_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace projeto_jobs_net_mvc.Servicos
{
    public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Vaga> Vagas { get; set; }
  }
  
}