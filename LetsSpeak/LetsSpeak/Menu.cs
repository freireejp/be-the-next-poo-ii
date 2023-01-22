using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSpeak
{
    internal static class Menu
    {
        public static int MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine("Seja bem vindo ao nosso dicionário.\n");
            Console.WriteLine("Selecione uma opção:\n");

            Console.WriteLine("1 - Adicionar um termo");
            Console.WriteLine("2 - Procurar um termo");
            Console.WriteLine("3 - Imprimir dicionário");
            Console.WriteLine("0 - Sair");

            bool checkInput;
            int input;

            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out input);

                if (input > 3 || input < 0 || checkInput == false)
                {
                    Console.WriteLine("Opção inváida. Tente novamente.");
                    checkInput = false;
                }
            } while (!checkInput);

            return input;
        }
    }
}
