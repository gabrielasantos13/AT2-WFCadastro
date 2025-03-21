using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string possFilhos { get; set; }
        public Double DddCelular { get; set; }
        public double cpf { get; set; }
        public string TipoTelefone { get; set; }

        public int Codigo { get; set; }

        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        public void listar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Possui Filhos: " + possFilhos);
            Console.WriteLine("DDD Celular: " + DddCelular);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Tipo Telefone: " + TipoTelefone);
            Console.WriteLine("Codigo: " + Codigo);
        }

    }
}
