using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

namespace LetsSpeak
{
    internal class Program
    {
        //Você foi contratado pela escola de idiomas “Let’s Speak”para a
        //construção de uma aplicação de dicionário para os alunos.
        //A aplicação deve ser construída conforme os requisitos a seguir.

        //A aplicação deve armazenar termos e seus significados.
        //Os termos podem ser compostos de uma ou mais palavras
        //(como, por exemplo, no caso de phrasal verbs e expressões idiomáticas).

        //A aplicação deve permitir que o aluno insira novos termos sempre que julgar necessário.
        //A aplicação deve permitir a busca de termos, não havendo distinção entre maiúsculas e minúsculas.
        //A busca deve ser feita apenas nos termos (não deve fazer buscas nas definições).
        //Quando nenhum termo correspondente à busca for encontrado,
        //a aplicação deve exibir na tela a mensagem “Nenhum termo encontrado”.
        //Caso contrário, devem ser exibidos todos os termos que correspondem à palavra buscada.
        //A aplicação não deve aceitar Wildcards (* e ?), a busca será
        //feita usando-se somente palavras inteiras ou parte de palavras.
        //Por exemplo, ao buscar por pea, o sistema deve retornar termos
        //como speak, pear, peacock, spears, etc.
        //A aplicação deve salvar os dados em um arquivo no disco de forma que,
        //ao ser iniciada, todos os termos salvos sejam carregados.

        static void Main(string[] args)
        {
            Dicionario dic = new Dicionario();
            dic.CarregarDicionario();

            int input;

            do
            {
                input = Menu.MostrarMenu();

                Console.WriteLine();

                switch (input)
                {
                    case 0:
                        Console.WriteLine("Você escolheu sair.");
                        break;
                    case 1:
                        dic.AdicionarTermo(); break;
                    case 2:
                        dic.ProcurarTermo(); break;
                    case 3:
                        dic.ImprimirDicionario(); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadKey();
            } while (input != 0);
        }
    }
}