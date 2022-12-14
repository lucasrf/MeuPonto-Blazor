using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeuPonto
{
    public class Usuario
    {
        [Key()]
        public int Codigo { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        [StringLength(255)]
        public string Senha { get; set; }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public static bool CheckExistencia(List<Usuario> lista, Usuario usuarioCheck)
        {
            bool check = false;
            foreach (Usuario usuarioLista in lista)
            {
                if(usuarioCheck.Nome == usuarioLista.Nome)
                {
                    check = true;
                }
            }
            return check;
        }

        public static bool CheckLogin(List<Usuario> lista, Usuario usuarioCheck)
        {
            bool check = false;
            foreach (Usuario usuarioLista in lista)
            {
                if (usuarioCheck.Nome == usuarioLista.Nome && usuarioCheck.Senha == usuarioLista.Senha)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
