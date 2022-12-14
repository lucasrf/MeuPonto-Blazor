using MeuPonto;
using Microsoft.EntityFrameworkCore;

namespace MeuPonto_Blazor.Data
{
    public class FuncionarioService : DbContext
    {
        private DbSet<Funcionario> _funcionarios { get; set; }

        public FuncionarioService()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DataUtils.SqlQuery,
                                        options => options.EnableRetryOnFailure());
        }
    }
}