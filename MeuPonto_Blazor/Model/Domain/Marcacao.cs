using System;
using System.ComponentModel.DataAnnotations;

namespace MeuPonto
{
    public class Marcacao
    {
        [Key()]
        public int Codigo { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Fim { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public TimeSpan GetIntervalo() => Fim - Inicio;

        public Marcacao(TimeSpan inicio, TimeSpan fim, string descricao = "")
        {
            Inicio = inicio;
            Fim = fim;
            Descricao = descricao;
        }
    }
}
