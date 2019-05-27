using Microsoft.EntityFrameworkCore;
using TesteCadastro.Domain.Entities;

namespace TesteCadastro.Infra.Data
{
    public class ContextBase : DbContext
    {

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StrincConectionConfig());
            }
        }

        private string StrincConectionConfig()
        {
            string strCon = "Server=(localdb)\\v11.0;Database=TesteCadastro;Trusted_Connection=True;MultipleActiveResultSets=true";

            return strCon;
        }
    }
}
