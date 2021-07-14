using System;

namespace revendedora
{
    class Program
    {
        public static void Main(string[] args)
        {
            double salarioFinal;

            Console.WriteLine("Escreva o número de carros vendidos:");
            string numCarros = Console.ReadLine();
            int num1 = Convert.ToInt32(numCarros);
            Console.WriteLine("Escreva o valor total de suas vendas:");
            string totalVenda = Console.ReadLine();
            int num2 = Convert.ToInt32(totalVenda);
            Console.WriteLine("Escreva o valor do sálario fixo:");
            string salario = Console.ReadLine();
            int num3 = Convert.ToInt32(salario);
            Console.WriteLine("Escreva o valor da comissão:");
            string valorCarros = Console.ReadLine();
            int num4 = Convert.ToInt32(valorCarros);

            salarioFinal = (num1 * num4) + (num2 * 0.05) + num3;
            
            Console.WriteLine("O sálario do vendendor é R$" +salarioFinal.ToString("F2"));
        }
    }
}
