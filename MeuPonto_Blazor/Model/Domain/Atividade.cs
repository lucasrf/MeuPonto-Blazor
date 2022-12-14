using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPonto
{
    public class Atividade
    {
        [Key()]
        public int Codigo { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public TimeSpan Tempo { get; set; }
        public Atividade(TimeSpan tempo, string descricao = "")
        {
            Descricao = descricao;
            Tempo = tempo;
        }
    }
}
