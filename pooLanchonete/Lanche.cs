using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    public class Lanche : Produto
    {
        public string TipoPao { get; set; }
        public string Recheio { get; set; }
        public string Molho { get; set; }

        public Lanche(string tipoPao, string recheio, string molho, int quantidade) : base(350, (decimal)18.99, quantidade)
        {
            this.TipoPao = tipoPao;
            this.Recheio = recheio;
            this.Molho = molho;
        }
    }
}
