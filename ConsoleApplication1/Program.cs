using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nomeProduto;
                int quantidade;
                double valorProduto, valorTotal;

                Console.WriteLine("******Exercício 4 - Avaliação 1*******");


                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade");
                quantidade = Convert.ToInt32(Console.ReadLine());

                valorTotal = quantidade * valorProduto;

                Console.Clear();
                Console.WriteLine("**** Venda de Produtos*******");
                Console.WriteLine("Produto: " + nomeProduto);
                Console.WriteLine("Qtde: " + quantidade + " x valor Unitário: " + valorProduto.ToString("C"));
                Console.WriteLine("total da Venda: " + valorTotal.ToString("C"));
                //.toString()-> converte numero para Texto, o "C" -> formata para moeda.
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Dados Digitados Invalidos!");
            }
            Console.ReadKey();


        }
    }
}
