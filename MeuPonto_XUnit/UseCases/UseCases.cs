using MeuPonto;
using System;
using Xunit;
using Blazor_PDF.PDF;

namespace MeuPonto_XUnit.UseCases
{
    public class InserirMarcacaoDePonto
    {
        [Fact]
        public void MarcacaoDeveCalcularCorretamenteOIntervalo()
        {
            //Arrange
            Marcacao mockMarcacao;
            TimeSpan expectedTimeSpan;
            TimeSpan marcacao1;
            TimeSpan marcacao2;
            //Act
            marcacao1 = new TimeSpan(08, 00, 00);
            marcacao2 = new TimeSpan(12, 00, 00);
            mockMarcacao = new Marcacao(marcacao1, marcacao2);
            expectedTimeSpan = new TimeSpan(04, 00, 00);
            //Assert
            Assert.Equal(expectedTimeSpan, mockMarcacao.GetIntervalo());
        }

        [Fact]
        public void MarcacaoSemPreenchimentoDeDataDeveCalcularIntervaloZero()
        {
            //Arrange
            Marcacao mockMarcacao;
            TimeSpan expectedTimeSpan;
            //Act
            mockMarcacao = new Marcacao(new TimeSpan(), new TimeSpan());
            expectedTimeSpan = new TimeSpan(00, 00, 00);
            //Assert
            Assert.Equal(expectedTimeSpan, mockMarcacao.GetIntervalo());
        }
    }

    public class InserirAtividades
    {
        [Fact]
        public void AtividadeDevePermitirEdiçãoNoTempoDeDuração()
        {
            //Arrange
            Atividade mockAtividade;
            TimeSpan tempoAtividade = new TimeSpan(01, 00, 00);
            //Act
            mockAtividade = new Atividade(new TimeSpan(), "Atividade 1");
            mockAtividade.Tempo = tempoAtividade;
            //Assert
            Assert.Equal(tempoAtividade, mockAtividade.Tempo);
        }

        [Fact]
        public void AtividadeSemPreenchimentoDeDescricaoDeveConterDescricaoVaziaESerEditavel()
        {
            //Arrange
            Atividade mockAtividade;
            TimeSpan tempoAtividade;
            string descricao;
            //Act
            descricao = "Descricao teste";
            tempoAtividade = new TimeSpan(01, 00, 00);
            mockAtividade = new Atividade(tempoAtividade);
            mockAtividade.Descricao = descricao;
            //Assert
            Assert.Equal(descricao, mockAtividade.Descricao);
        }
    }

    public class ConsultarPeriodoPonto
    {
        [Fact]
        public void EmpresaDeveAbrirPeriodoNoMesEAnoDaDataInformada()
        {
            //Arrange
            Empresa mockEmpresa;
            string descricaoPeriodo;
            //Act
            mockEmpresa = new Empresa();
            mockEmpresa.AbrirPeriodo(new DateTime(2022, 12, 1));
            descricaoPeriodo = "12/2022";
            //Assert
            Assert.Equal(mockEmpresa.Periodos[0].Descricao, descricaoPeriodo);
        }

        [Fact]
        public void FuncionarioNaoDeveSerCapazDeAdicionarPontoComPeriodoFechado()
        {
            //Arrange
            Empresa mockEmpresa;
            Funcionario mockFuncionario;
            Ponto mockPonto;
            //Act
            mockEmpresa = new Empresa();
            mockFuncionario = new Funcionario("Lucas Rodrigues", 0);
            mockPonto = new Ponto(new DateTime(2023, 01, 01));
            mockEmpresa.Funcionarios.Add(mockFuncionario);
            mockFuncionario.Pontos.Add(mockPonto);
            //Assert
            foreach (Periodo p in mockEmpresa.Periodos)
            {
                Assert.Empty(mockFuncionario.GetPontosByPeriodo(p));
            }
        }
    }

    public class EditarMarcacaoPonto
    {
        [Fact]
        public void FuncionarioDeveSerCapazDeEditarPonto()
        {
            //Arrange
            Funcionario mockFuncionario;
            Ponto mockPonto;
            //Act
            mockFuncionario = new Funcionario("Lucas Rodrigues", 0);
            mockPonto = new Ponto(new DateTime(2022, 11, 1));
            mockFuncionario.Pontos.Add(mockPonto);
            mockFuncionario.Pontos[0].Date = new DateTime(2022, 12, 1);
            //Assert
            Assert.Equal(mockFuncionario.Pontos[0].Date, new DateTime(2022, 12, 1));
        }
        [Fact]
        public void PontoAlteradoNãoDeveAparecerNosResultadosDoPeriodoAnterior()
        {
            //Arrange
            Empresa mockEmpresa;
            Funcionario mockFuncionario;
            Ponto mockPonto;
            DateTime data1;
            DateTime data2;
            Periodo mockPeriodo;
            //Act
            mockEmpresa = new Empresa();
            mockFuncionario = new Funcionario("Lucas Rodrigues", 0);
            mockPonto = new Ponto(new DateTime(2022, 11, 1));
            data1 = new DateTime(2022, 11, 1);
            data2 = new DateTime(2023, 11, 1);
            mockPeriodo = new Periodo(data1);
            mockEmpresa.Periodos.Add(new Periodo(data1));
            mockFuncionario.Pontos.Add(mockPonto);
            mockFuncionario.Pontos[0].Date = data2;
            //Assert
            foreach (Periodo p in mockEmpresa.Periodos)
            {
                Assert.Empty(mockFuncionario.GetPontosByPeriodo(mockPeriodo));
            }
        }
    }

    public class ConsultarJornadaDeTrabalho
    {
        [Fact]
        public void FuncionarioDeveSerCapazDeConsultarJornada()
        {
            //Arrange
            Funcionario mockFuncionario;
            Ponto mockPonto;
            DateTime mockData;
            Marcacao mockMarcacao;
            TimeSpan mockTimeSpan;
            //Act
            mockFuncionario = new Funcionario("Lucas Rodrigues", 0);
            mockData = new DateTime(2022, 11, 1);
            mockPonto = new Ponto(mockData);
            mockTimeSpan = new TimeSpan(12, 00, 00);
            mockFuncionario.Pontos.Add(mockPonto);
            mockFuncionario.Pontos[0].Date = mockData;
            mockMarcacao = new Marcacao(mockTimeSpan, mockTimeSpan);
            mockPonto.Marcacoes.Add(mockMarcacao);
            //Assert
            Assert.Equal(mockFuncionario.Pontos[0].Marcacoes[0].GetIntervalo(), (mockMarcacao.Fim - mockMarcacao.Inicio));
        }
        [Fact]
        public void MarcacaoVaziaDeveRetornarJornadaZero()
        {
            //Arrange
            Marcacao mockMarcacao;
            TimeSpan mockTimeSpanInicio;
            TimeSpan mockTimeSpanFinal;
            //Act
            mockTimeSpanInicio = new TimeSpan(00, 00, 00);
            mockTimeSpanFinal = new TimeSpan(00, 00, 00);
            mockMarcacao = new Marcacao(mockTimeSpanInicio, mockTimeSpanFinal);
            //Assert
            Assert.Equal(mockMarcacao.GetIntervalo(), mockTimeSpanFinal);
        }
    }

    public class EditarAtividades
    {
        [Fact]
        public void FuncionarioDeveSerCapazDeEditarAtividade()
        {
            //Arrange
            Funcionario mockFuncionario;
            Ponto mockPonto;
            Atividade mockAtividade;
            Atividade mockAtividade2;
            DateTime mockData;
            TimeSpan mockTimeSpan;
            //Act
            mockData = new DateTime(2022, 11, 1);
            mockTimeSpan = new TimeSpan(12, 00, 00);
            mockFuncionario = new Funcionario("Lucas Rodrigues", 0);
            mockPonto = new Ponto(mockData);
            mockAtividade = new Atividade(mockTimeSpan, "Atividade teste");
            mockAtividade2 = new Atividade(mockTimeSpan, "Atividade teste 2");
            mockFuncionario.Pontos.Add(mockPonto);
            mockFuncionario.Pontos[0].Atividades.Add(mockAtividade);
            mockFuncionario.Pontos[0].Atividades[0] = mockAtividade2;
            //Assert
            Assert.Equal(mockFuncionario.Pontos[0].Atividades[0], mockAtividade2);

        }
        [Fact]
        public void AtividadeVaziaDeveRetornarTempoZero()
        {
            //Arrange
            Atividade mockAtividade;
            TimeSpan mockTimeSpan;
            //Act
            mockTimeSpan = new TimeSpan(0);
            mockAtividade = new Atividade(mockTimeSpan, "Atividade teste");
            //Assert
            Assert.Equal(mockAtividade.Tempo, mockTimeSpan);
        }
    }

    public class GerarRelatorioDeAtividades
    {
        [Fact]
        public void RelatorioDeveSerGeradoEmPdf()
        {
            //Arrange
            Funcionario mockFuncionario;
            Periodo mockPeriodo;
            DateTime mockData;
            byte[] mockPdf;
            Report mockReport;
            //Act
            mockReport = new Report();
            mockData = new DateTime(2022, 11, 1);
            mockFuncionario = new Funcionario("Lucas Rodrigues", 0);
            mockPeriodo = new Periodo(mockData);
            mockPdf = mockReport.ReportPDF(mockFuncionario, mockPeriodo);
            //Assert
            Assert.NotNull(mockPdf);
        }
        [Fact]
        public void RelatorioNaoDeveSerGeradoCasoNaoHajaFuncionarioSelecionado()
        {
            //Arrange
            Funcionario mockFuncionario;
            Periodo mockPeriodo;
            DateTime mockData;
            byte[] mockPdf;
            Report mockReport;
            //Act
            mockReport = new Report();
            mockData = new DateTime(2022, 11, 1);
            mockPeriodo = new Periodo(mockData);
            mockFuncionario = null;
            mockPdf = null;
            //Assert
            Assert.False(testPdfGeneration(mockPdf, mockReport, mockFuncionario, mockPeriodo));
        }

        public bool testPdfGeneration(byte[] mockPdf, Report mockReport, Funcionario mockFuncionario, Periodo mockPeriodo)
        {
            try
            {
                mockPdf = mockReport.ReportPDF(mockFuncionario, mockPeriodo);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
