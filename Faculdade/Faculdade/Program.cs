using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Faculdade
{
    public class Program
    {
        public static void DisplayPublicProperties(object objeto)
        {
            PropertyInfo[] propriedades = objeto.GetType().GetProperties();

            Console.WriteLine("Propriedades:\n");

            foreach (var propriedade in propriedades)
            {
                Console.WriteLine(propriedade.Name);
            }

            Console.WriteLine();
        }

        public static void CreateInstance()
        {
            Type tipo = typeof(Student);

            object novaInstancia = Activator.CreateInstance(tipo);

            Console.WriteLine($"Propriedades alteradas do objeto { novaInstancia.GetType().Name }:");
            Console.WriteLine();

            PropertyInfo propName = tipo.GetProperty("Name");
            propName.SetValue(novaInstancia, "Eder Freire", null);

            PropertyInfo propUniversity = tipo.GetProperty("University");
            propUniversity.SetValue(novaInstancia, "UFF", null);

            PropertyInfo propRollNumber = tipo.GetProperty("RollNumber");
            propRollNumber.SetValue(novaInstancia, 2, null);

            MethodInfo metodo = tipo.GetMethod("DisplayInfo");
            object resultado = metodo.Invoke(novaInstancia, null);
        }

        static void Main(string[] args)
        {
            Student estudante = new Student();

            DisplayPublicProperties(estudante);

            CreateInstance();            
        }
    }
}