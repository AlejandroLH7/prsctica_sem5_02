using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prsctica_sem5_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            int resultado = 1; 

            if (exponente < 0){
                Console.WriteLine("Lo sentimos el programa solo maneja exponentes positivos :c.");
                return;
            }

            for (int i = 0; i < exponente; i++){ 
                resultado *= baseNum;
            }
            Console.WriteLine($"La potencia es {resultado}");
            Console.ReadKey();
        }
    }
}
