using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================BEM VINDO A LANCHONETE QUASE TRES LANCHES======================");
            Console.WriteLine("Deseja inciar um novo pedido? s/n ");
            if (Console.ReadLine() == "s")
            {
                bool isNovoItem = true;

                List<Lanche> lanches = new List<Lanche>();
                List<Pizza> pizzas = new List<Pizza>();
                List<Salgadinho> salgadinhos = new List<Salgadinho>();
                
                while (isNovoItem)
                {
                    Console.WriteLine("Qual Item deseja Adicionar? \n 1 - Lanche \n 2 - Salgadinho \n 3 - Pizza");
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "1":
                            Console.WriteLine("Qual será o tipo de pão? \n 1 - Francês \n 2 - Americano \n 3 - Australiano");
                            string tipoPao = Console.ReadLine();

                            Console.WriteLine("Qual será o recheio? \n 1 - Calabresa \n 2 - Carne Moída \n 3 - Hamburguer Bovino");
                            string recheioLanche = Console.ReadLine();

                            Console.WriteLine("Qual será o molho? \n 1 - Barbecue \n 2 - Maionese \n 3 - Ketchup");
                            string molhoLanche = Console.ReadLine();

                            Console.WriteLine("Quantidade de lanches iguais: ");
                            int quantidadeLanche = Convert.ToInt32(Console.ReadLine());

                            Lanche lanche = new Lanche(tipoPao, recheioLanche, molhoLanche, quantidadeLanche);
                            lanches.Add(lanche);

                            break;

                        case "2":
                            Console.WriteLine("Qual será o tipo de salgado? \n 1 - Assado \n 2 - Frito");
                            string tipoSalgado = Console.ReadLine();

                            Console.WriteLine("Qual será o recheio? \n 1 - Calabresa \n 2 - Carne Moída \n 3 - Frango Desfiado");
                            string recheioSalgado = Console.ReadLine();

                            Console.WriteLine("Qual será o molho? \n 1 - Barbecue \n 2 - Maionese \n 3 - Ketchup");
                            string molhoSalgado = Console.ReadLine();

                            Console.WriteLine("Quantidade de Salgados iguais: ");
                            int quantidadeSalgado = Convert.ToInt32(Console.ReadLine());

                            Salgadinho salgadinho = new Salgadinho(tipoSalgado, recheioSalgado, molhoSalgado, quantidadeSalgado);
                            salgadinhos.Add(salgadinho);

                            break;

                        case "3":

                            Console.WriteLine("Qual será o recehio da pizza? \n 1 - Frango com Catupiry \n 2 - Marguerita \n 3 - Portuguesa");
                            string recheioPizza = Console.ReadLine();

                            Console.WriteLine("Qual será o molho? \n 1 - Apenas Azeite \n 2 - Ketchup \n 3 - Maionese");
                            string molhoPizza = Console.ReadLine();

                            Console.WriteLine("A borda será recheada? s/n");
                            bool bordaRecheada = Console.ReadLine().ToUpper().Contains("S");

                            Console.WriteLine("Quantidade de Pizzas iguais: ");
                            int quantidadePizza = Convert.ToInt32(Console.ReadLine());

                            Pizza pizza = new Pizza(recheioPizza, bordaRecheada, molhoPizza, quantidadePizza);
                            pizzas.Add(pizza);
                            break;
                    }

                    Console.WriteLine("Deseja adicionar um novo item? s/n");
                    isNovoItem = Console.ReadLine().ToUpper().Contains("S");
                }

                Prato prato = new Prato(lanches, salgadinhos, pizzas);

                Console.WriteLine("Qual o nome do cliente para fechar o pedido? ");
                string nomeCliente = Console.ReadLine();

                Pedido pedido = new Pedido(nomeCliente, prato);

                Console.WriteLine($"Cliente: {pedido.NomeCliente} \n Valor Total: {pedido.ValorTotal}");

                pedido.ImprimePedido();



                Console.ReadKey();
            }

        }
    }
}
