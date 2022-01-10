using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    public class Salgadinho : Produto
    {
        public string TipoSalgado { get; set; }
        public string Recheio { get; set; }
        public string Massa { get; set; }


        public Salgadinho(string tipoSalgado, string recheio, string massa, int quantidade) : base(1000, (decimal)5.00, quantidade)
        {
            this.TipoSalgado = tipoSalgado;
            this.Recheio = recheio;
            this.Massa = massa;
        }
    }
}
