using System.Threading.Tasks;
using MeuPonto;
using Microsoft.EntityFrameworkCore;

namespace MeuPonto_Blazor.Data
{
    public class PontoService : DbContext
    {
        private DbSet<Ponto> _pontos { get; set; }

        public PontoService()
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

        public Task<Ponto[]> GetApontamentos(Funcionario funcionario, Periodo periodo) => 
            Task.FromResult(funcionario.GetPontosByPeriodo(periodo).ToArray());
    }
}