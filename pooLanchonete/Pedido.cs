using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    public class Pedido
    {
        public string NomeCliente { get; set; }

        public string NotaFiscal { get; set; }

        public decimal ValorTotal { get; set; }

        public Prato Prato { get; set; }


        public Pedido(string nomeCliente, Prato prato)
        {
            this.NomeCliente = nomeCliente;
            this.Prato = prato;
            this.NotaFiscal = "";

            //aqui uso o Linq para fazer a soma de todos os atributos PRECO da lista que passei, e faço isso para as 3 listas
            this.ValorTotal = prato.Salgadinhos.Sum(item => item.Preco) + prato.Pizzas.Sum(item => item.Preco) + prato.Pizzas.Sum(item => item.Preco);


        }

    }
}
