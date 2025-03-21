using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastro
{
    internal class Produto
    {
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public int codigo { get; set; }
       public string? status { get; set; }
        public DateTime dataCadastro { get; set; }
         public string? Ativo { get; set; }
        public string? Inativo { get; set; }

            public static List<Produto> ListaProdutos = new List<Produto>();

    }
}
