using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuPonto;
using Microsoft.EntityFrameworkCore;

namespace MeuPonto_Blazor.Data
{
    public class UsuarioService : DbContext
    {
        public bool LoginStatus { get; set; }
        public static DbSet<Usuario> usuarios { get; set; }

        public UsuarioService()
        {
            LoginStatus = false;

            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();

            Populate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DataUtils.SqlQuery,
                                        options => options.EnableRetryOnFailure());
        }

        public void Populate() // Dados para teste da aplicação => Conforme especificação do trabalho
        {
            usuarios.Add(new Usuario("lucas", "123"));
            usuarios.Add(new Usuario("a", "a"));
            this.SaveChanges();
        }
    }
}