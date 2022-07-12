using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Processar();

            Console.ReadKey();
        }

        private static void Processar()
        {
            int Idade;
            Console.Write("Informar a sua idade: ");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 18 && <=67);
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permitido doar sangue");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não pode doar sangue");
            }
        }
    }
}
