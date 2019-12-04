using Microsoft.EntityFrameworkCore;
using TDEDominio.Entidade;
using TDEInfraData.Mapping;

namespace TDEInfraData.Context
{
    public class CampanhaContext : DbContext
    {
        public DbSet<Avaliacao> avaliacao { get; set; }
        public DbSet<Cadastro> cadastro { get; set; }
        public DbSet<Campanha> campanhas { get; set; }
        public DbSet<Endereco> endereco { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Sugestoes> sugestoes { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Usuario> usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8ELNPKK;Initial Catalog=TDE 2Bimestre;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
            modelBuilder.Entity<Cadastro>(new CadastroMap().Configure);
            modelBuilder.Entity<Campanha>(new CampanhaMap().Configure);
            modelBuilder.Entity<Endereco>(new EnderecoMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<Sugestoes>(new SugestaoMap().Configure);
            modelBuilder.Entity<Users>(new UsersMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);

        }

    }
}
