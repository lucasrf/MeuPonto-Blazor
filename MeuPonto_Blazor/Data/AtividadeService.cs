using System.Threading.Tasks;
using MeuPonto;
using Microsoft.EntityFrameworkCore;

namespace MeuPonto_Blazor.Data
{
    public class AtividadeService : DbContext
    {
        private DbSet<Atividade> _atividades { get; set; }

        public AtividadeService()
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