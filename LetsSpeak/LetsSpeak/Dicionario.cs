using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSpeak
{
    public class Dicionario
    {
        public string Termo { get; private set; }
        public string Definicao { get; private set; }

        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        public void AdicionarTermo()
        {
            Console.WriteLine("Adicionar um termo ao dicionário\n");

            Console.WriteLine("Termo:");
            Termo = Console.ReadLine();

            Console.WriteLine("Definição:");
            Definicao = Console.ReadLine();

            if (Utils.SomenteLetras(Termo))
            {
                if (!dicionario.ContainsKey(Termo.ToLower()))
                {
                    dicionario.Add(Termo.ToLower(), Definicao.ToLower());
                    EscreverNoArquivo(Termo, Definicao);
                    Console.WriteLine("\nItens adicionados com sucesso.");
                }
                else
                {
                    Console.WriteLine("Este termo já foi adicionado. Tente um novo termo.");
                }
            }
            else
            {
                Console.WriteLine("Use somente letras. Tente novamente.");
            }
        }

        public void ImprimirDicionario()
        {
            Console.WriteLine("Dicionário:\n");

            foreach (var item in dicionario)
            {
                Console.WriteLine($"Termo: {item.Key}\nDefinição: {item.Value}");
                Console.WriteLine();
            }
        }

        public static IEnumerable<KeyValuePair<string, string>> ProcurarTermo(Dictionary<string, string> dicionario, string termo)
        {
            return dicionario.Where(x => x.Key.ToLower().Contains(termo.ToLower()));
        }

        public void ProcurarTermo()
        {
            Console.WriteLine("Pesquisa:");
            string termoProcurado = Console.ReadLine();

            Console.WriteLine("Resultado da busca:\n");

            Dictionary<string, string> resultados = new Dictionary<string, string>();
            IEnumerable<KeyValuePair<string, string>> resultadosDaBusca = ProcurarTermo(dicionario, termoProcurado);
            foreach (var item in resultadosDaBusca)
            {
                resultados.Add(item.Key, item.Value);
            }

            if (resultados.Count > 0)
            {
                foreach (KeyValuePair<string, string> item in resultados)
                {
                    Console.WriteLine($"Termo: {item.Key}\nDefinição: {item.Value}\n");
                }
            }
            else
            {
                Console.WriteLine("Nenhum termo encontrado.");
            }
        }

        public void CarregarDicionario()
        {
            if (!File.Exists("dicionario.txt"))
            {
                using (StreamWriter sw = new StreamWriter("dicionario.txt"));
            }

            string[] linhas = File.ReadAllLines("dicionario.txt");
            foreach (string linha in linhas)
            {
                string[] elementos = linha.Split(',');
                dicionario.Add(elementos[0], elementos[1]);
            }
        }

        private static void EscreverNoArquivo(string termo, string definicao)
        {
            using (StreamWriter sw = new StreamWriter("dicionario.txt", true))
            {
                sw.WriteLine($"{termo},{definicao}");
            }
        }
    }
}