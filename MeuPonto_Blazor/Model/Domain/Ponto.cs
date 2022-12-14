using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPonto
{
    public class Ponto
    {
        [Key()]
        public int Codigo { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Atividade")]
        public List<Atividade> Atividades { get; set; } = new List<Atividade>();
        [ForeignKey("Marcacao")]
        public List<Marcacao> Marcacoes { get; set; } = new List<Marcacao>();
        [StringLength(255)]
        public string Observacao { get; set; }
        public Ponto(DateTime date)
        {
            Date = date;
            Atividades = new List<Atividade>();
            Marcacoes = new List<Marcacao>();
            Observacao = "-";
        }
    }
}
