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
        Dictionary<string, string> dicionario = new Dictionary<string, string>();
        public static void AdicionarTermo(Dictionary<string, string> dicionario)
        {
            Console.WriteLine("Adicionar um termo ao dicionário\n");

            Console.WriteLine("Termo:");
            string termo = Console.ReadLine();

            Console.WriteLine("Definição:");
            string definicao = Console.ReadLine();

            if (Utils.SomenteLetras(termo))
            {
                if (!dicionario.ContainsKey(termo.ToLower()))
                {
                    dicionario.Add(termo.ToLower(), definicao.ToLower());
                    EscreverNoArquivo(termo, definicao);
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

        public static void ImprimirDicionario(Dictionary<string, string> dicionario)
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

        public static void ProcurarTermo(Dictionary<string, string> dicionario)
        {
            Console.WriteLine("Pesquisa:");
            string termo = Console.ReadLine();

            Console.WriteLine("Resultado da busca:\n");

            Dictionary<string, string> resultados = new Dictionary<string, string>();
            IEnumerable<KeyValuePair<string, string>> results = ProcurarTermo(dicionario, termo);
            foreach (var item in results)
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

        public static void CarregarDicionario(Dictionary<string, string> dicionario)
        {
            if (!File.Exists("dicionario.txt"))
            {
                //Console.WriteLine("Arquivo de dicionário encontrado.");
                using (StreamWriter sw = new StreamWriter("dicionario.txt"));
                //Console.WriteLine("Arquivo carregado com sucesso.");
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