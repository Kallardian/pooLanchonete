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

            //aqui uso o Linq para fazer a soma de todos os atributos PRECO * QUANTIDADE da lista que passei, e faço isso para as 3 listas
            this.ValorTotal = (decimal)(prato.Salgadinhos.Sum(item => item.Preco * item.Quantidade) + prato.Lanches.Sum(item => item.Preco * item.Quantidade) + prato.Pizzas.Sum(item => item.Preco * item.Quantidade));


        }

        public void ImprimePedido()
        {
            foreach (var item in this.Prato.Lanches)
            {
                if (item != null)
                {
                    Console.WriteLine("======Lanche======");
                    Console.WriteLine("Pão: " + item.TipoPao);
                    Console.WriteLine("Molho: " + item.Molho);
                    Console.WriteLine("Recheio: " + item.Recheio);
                    Console.WriteLine("Valor: " + item.Preco);
                    Console.WriteLine("Quantidade: " + item.Quantidade);
                    Console.WriteLine("======Lanche======");
                }
            }
            foreach (var item in this.Prato.Pizzas)
            {
                if (item != null)
                {
                    Console.WriteLine("=======Pizza======");
                    Console.WriteLine("Recheio: " + item.Recheio);
                    Console.WriteLine("Molho: " + item.Molho);
                    Console.WriteLine($"Borda Recheada? {item.BordaRecheada}");
                    Console.WriteLine("Valor: " + item.Preco);
                    Console.WriteLine("Quantidade: " + item.Quantidade);
                    Console.WriteLine("=======Pizza======");
                }
            }
            foreach (var item in this.Prato.Salgadinhos)
            {
                if (item != null)
                {
                    Console.WriteLine("======Salgadinho=====");
                    Console.WriteLine("Tipo do Salgado: " + item.TipoSalgado);
                    Console.WriteLine("Recheio: " + item.Recheio);
                    Console.WriteLine("Massa: " + item.Massa);
                    Console.WriteLine("Valor: " + item.Preco);
                    Console.WriteLine("Quantidade: " + item.Quantidade);
                    Console.WriteLine("======Salgadinho=====");
                }
            }
        }

    }
}
