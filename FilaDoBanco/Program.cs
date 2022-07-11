using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Informe o número de casos de teste: ");
            int qtdTeste = int.Parse(Console.ReadLine()); ;

            for (int n = 0; n < qtdTeste; n++)
            {
                //Console.WriteLine("Informe o número de clientes: ");
                int clientes = int.Parse(Console.ReadLine());
                //Console.WriteLine("Informe as senhas recebidas por sms: ");
                string senhas = Console.ReadLine();
                int[] numeracao = Array.ConvertAll(senhas.Split(' '), s => int.Parse(s));
                int mantido = 0;
                //Console.WriteLine(string.Join(" ", numeracao));        
                int[] ordenada = new int[numeracao.Length];
                Array.Copy(numeracao, ordenada, numeracao.Length);
                Array.Sort(ordenada);
                Array.Reverse(ordenada);

                for (int i = 0; i < numeracao.Length; i++)
                {
                    if (numeracao[i] != ordenada[i])
                    {
                        mantido++;
                    }
                }
                Console.WriteLine(numeracao.Length - mantido);
            }
        }
    }
}
