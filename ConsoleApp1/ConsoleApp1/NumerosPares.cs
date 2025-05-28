using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumerosPares
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            var entrada1 = Console.ReadLine();
            double numero = double.Parse(entrada1);
            int resto = (int)numero % 2;
            if (resto == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es Inpar");
            }
        }
    }
}
