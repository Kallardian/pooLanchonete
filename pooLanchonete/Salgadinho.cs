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


        public Salgadinho(decimal peso, decimal preco, string tipoSalgado, string recheio, string massa) : base(peso, preco)
        {
            this.TipoSalgado = tipoSalgado;
            this.Recheio = recheio;
            this.Massa = massa;
        }
    }
}
