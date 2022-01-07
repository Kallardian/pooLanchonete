using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    public class Produto
    {
        public decimal Peso { get; set; }

        public decimal Preco { get; set; }

        public DateTime Validade { get; set; }


        public Produto(decimal peso, decimal preco)
        {
            this.Validade = DateTime.Now.AddDays(7);
            this.Peso = peso;
            this.Preco = preco;
        }
    }
}
