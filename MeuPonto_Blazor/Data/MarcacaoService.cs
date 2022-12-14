using System.Threading.Tasks;
using MeuPonto;
using Microsoft.EntityFrameworkCore;

namespace MeuPonto_Blazor.Data
{
    public class MarcacaoService : DbContext
    {
        private DbSet<Marcacao> _marcacoes { get; set; }

        public MarcacaoService()
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
