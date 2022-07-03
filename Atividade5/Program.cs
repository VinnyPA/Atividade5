using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            contador = 0;

            while (contador < 100)
            {
                contador++; 
                contador++;
                Console.WriteLine(contador);
            }
;
            Console.ReadKey();
        }
    }
}
