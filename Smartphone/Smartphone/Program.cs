using Smartphone.Models;

namespace Smartphone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorola motorola = new Motorola("(22) 99876-5432", "Moto G", "9876543210", 2);
            Console.WriteLine("Usando o smartphone Motorola:\n");
            motorola.Ligar();
            motorola.ReceberLigacao();
            motorola.InstalarAplicativo("Whatsapp");

            Console.WriteLine();

            Iphone iphone = new Iphone("(31) 91234-5678", "13 Pro Max", "0123456789", 5);
            Console.WriteLine("Usando o smartphone Iphone:\n");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}