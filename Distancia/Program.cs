using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = 2 * quilometros; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}
