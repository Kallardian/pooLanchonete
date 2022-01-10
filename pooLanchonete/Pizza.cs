using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    public class Pizza : Produto
    {
        public string Recheio { get; set; }
        public bool BordaRecheada { get; set; }
        public string Molho { get; set; }

        public Pizza(string recheio, bool bordaRecheada, string molho, int quantidade) : base(500, (decimal)25.00, quantidade)
        {
            this.Recheio = recheio;
            this.BordaRecheada = bordaRecheada;
            this.Molho = molho;
        }
    }
}
