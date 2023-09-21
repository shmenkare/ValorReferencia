using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        { int num = 5;

            Console.WriteLine("El valor de num antes de la funcion es {0}", num);

            Cambiar(num);

            Console.WriteLine("El valor de num despues de la funcion es {0}", num);

            Console.WriteLine("El valor de num antes de la funcion es {0}", num);

            Cambiar(ref num);

            Console.WriteLine("El valor de num despues de la funcion es {0}", num);

            Console.ReadKey();  

        }
        static void Cambiar(int numero)
        {
            numero = 15;

        }
        static void Cambiar(ref int numero)
        {
            numero = 20;

        }




    }
}
