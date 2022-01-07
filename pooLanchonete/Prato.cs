using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    public class Prato
    {
        public List<Lanche> Lanches { get; set; }
        public List<Salgadinho> Salgadinhos { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Prato(List<Lanche> lanches, List<Salgadinho> salgadinhos, List<Pizza> pizzas)
        {
            this.Lanches = lanches;
            this.Salgadinhos = salgadinhos;
            this.Pizzas = pizzas;
        }
    }
}
