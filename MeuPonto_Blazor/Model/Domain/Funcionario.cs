using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPonto
{
    public class Funcionario
    {
        [Key()]
        public int Codigo { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        [ForeignKey("Ponto")]
        public List<Ponto> Pontos { get; set; } = new List<Ponto>();

        public Funcionario(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public List<Ponto> GetPontosByPeriodo(Periodo periodo)
        {
            List<Ponto> pontos = new List<Ponto>();
            foreach (var ponto in Pontos)
            {
                if (ponto.Date >= periodo.Inicio && ponto.Date <= periodo.Fim)
                {
                    pontos.Add(ponto);
                }
            }
            return pontos;
        }
    }
}
