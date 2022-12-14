using MeuPonto;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MeuPonto_Blazor.Data
{
    public class PeriodoService : DbContext
    {
        private DbSet<Periodo> periodos { get; set; }

        public PeriodoService()
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