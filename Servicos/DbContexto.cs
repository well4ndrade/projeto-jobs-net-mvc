using projeto_jobs_net_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace projeto_jobs_net_mvc.Servicos
{
    public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }


  }
  
}