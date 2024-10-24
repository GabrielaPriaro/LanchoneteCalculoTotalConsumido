//Problema "lanchonete" (adaptado de URI 1038)
//Uma lanchonete possui vários produtos. Cada produto possui um código
//e um preço. Você deve fazer um programa para ler o código e a
//quantidade comprada de um produto (suponha um código válido), e daí
//informar qual o valor a ser pago, com duas casas decimais, conforme
//tabela de produtos ao lado.
//Código do produto
//Preço do produto
//1 R$ 5.00
//2 R$ 3.50
//3 R$ 4.80
//4 R$ 8.90
//5 R$ 7.32 

using System.Globalization;

namespace LanchoneteCalculoTotalConsumido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codProduto, quantComprada;
            double valorProduto,valorTotal;

            CultureInfo CI= CultureInfo.InvariantCulture;

            Console.Write("Codigo do produto comprado: ");
            codProduto = int.Parse(Console.ReadLine());

            switch (codProduto)
            {
                case 1:
                    valorProduto = 5.00;
                    break;

                case 2:
                    valorProduto = 3.50;
                    break;

                case 3:
                    valorProduto = 4.80;
                    break;

                case 4:
                    valorProduto = 8.90;
                    break;

                case 5:
                    valorProduto = 7.32;
                    break;

                default:
                    Console.WriteLine("Produto nao encontrado");
                    return;
            }

            Console.Write("Quantidade comprada: ");
            quantComprada = int.Parse(Console.ReadLine());

            valorTotal = valorProduto * quantComprada;

            Console.WriteLine($"Valor a pagar: R$ {valorTotal.ToString("F2", CI)}");

        }
    }
}
