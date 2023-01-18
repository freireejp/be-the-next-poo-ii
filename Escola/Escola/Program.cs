namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escola\n");

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Eder";
            pessoa.Idade = 27;
            pessoa.Cumprimentar();
            pessoa.DizerIdade();
            Console.WriteLine();

            Aluno aluno = new Aluno();
            aluno.Nome = "João";
            aluno.Idade = 21;
            aluno.IrParaEscola();
            aluno.Cumprimentar();
            aluno.DizerIdade();
            Console.WriteLine();

            Professor professor = new Professor();
            professor.Nome = "José";
            professor.Idade = 30;
            professor.Cumprimentar();
            professor.DizerIdade();
            professor.Explicar("ciência da computação");
        }
    }
}