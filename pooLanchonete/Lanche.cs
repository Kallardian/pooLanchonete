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

        public Lanche(decimal peso, decimal preco, string tipoPao, string recheio, string molho) : base(peso, preco)
        {
            this.TipoPao = tipoPao;
            this.Recheio = recheio;
            this.Molho = molho;
        }
    }
}
