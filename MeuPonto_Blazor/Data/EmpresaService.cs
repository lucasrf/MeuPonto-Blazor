using System;
using System.Linq;
using MeuPonto;
using Microsoft.EntityFrameworkCore;

namespace MeuPonto_Blazor.Data
{
    public class EmpresaService : DbContext
    {
        public DbSet<Empresa> _empresas { get; set; } // Empresa selecionada TODO: Seleção de uma empresa diferente
        public static Periodo SelectedPeriodo { get; set; } // Periodo selecionado nas telas de apontamento e relatório
        public static Ponto SelectedPonto { get; set; } // Ponto selecionado na tela de apontamento
        public static TimeSpan JornadaDiaria { get { return new TimeSpan(08, 45, 00); } }

        public EmpresaService()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();

            SelectedPeriodo = new Periodo(DateTime.MinValue);
            SelectedPonto = new Ponto(DateTime.MinValue);
            Populate();
        }
        public Empresa GetEmpresa() // Encapsula a empresa selecionada
        {
            return _empresas.First();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DataUtils.SqlQuery,
                                        options => options.EnableRetryOnFailure());
        }

        public void Populate() // Dados para teste da aplicação => Conforme especificação do trabalho
        {
            _empresas.Add(new Empresa());
            GetEmpresa().Funcionarios.Add(new Funcionario("Lucas Rodrigues", 0));

            GetEmpresa().AbrirPeriodo(new DateTime(2022, 10, 1));
            GetEmpresa().AbrirPeriodo(new DateTime(2022, 11, 1));
            GetEmpresa().AbrirPeriodo(new DateTime(2022, 12, 1));
            GetEmpresa().AbrirPeriodo(new DateTime(2023, 1, 1));

            GetEmpresa().Funcionarios.First().Pontos[0].Marcacoes.Add(new Marcacao(new TimeSpan(08, 00, 00), new TimeSpan(12, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[0].Marcacoes.Add(new Marcacao(new TimeSpan(13, 00, 00), new TimeSpan(18, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[1].Marcacoes.Add(new Marcacao(new TimeSpan(07, 00, 00), new TimeSpan(12, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[1].Marcacoes.Add(new Marcacao(new TimeSpan(13, 00, 00), new TimeSpan(17, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[2].Marcacoes.Add(new Marcacao(new TimeSpan(07, 00, 00), new TimeSpan(12, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[2].Marcacoes.Add(new Marcacao(new TimeSpan(13, 00, 00), new TimeSpan(17, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[3].Marcacoes.Add(new Marcacao(new TimeSpan(08, 00, 00), new TimeSpan(12, 00, 00)));
            GetEmpresa().Funcionarios.First().Pontos[3].Marcacoes.Add(new Marcacao(new TimeSpan(12, 30, 00), new TimeSpan(17, 45, 00)));
            this.SaveChanges();
        }
    }
}
