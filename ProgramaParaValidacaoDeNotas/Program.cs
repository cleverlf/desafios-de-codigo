using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaParaValidacaoDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double soma = 0;
            bool entrada;
            
            while (x < 2)
            {
                entrada = true;

                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else if (x == 0)
                {
                    soma = nota;
                    x++;
                }
                else if (x == 1)
                {
                    double media = (soma + nota) / 2;
                    Console.Write("media = ");
                    Console.WriteLine(media.ToString("N2"));
                    while (entrada == true)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        double res = double.Parse(Console.ReadLine());
                        if (res == 1)
                        {
                            entrada = false;
                            x = 0;
                        }
                        else if (res == 2)
                        {
                            entrada = false;
                            x++;
                        }
                    }
                }
            }
        }
    }
}
