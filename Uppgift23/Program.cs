using System;
namespace uppggift23
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hej, välkommen till bil uthyrning.");
                Console.WriteLine("Hur många dagar vill du hyra bilen?");
                string antaldagar = Console.ReadLine();
                int intdagar = int.Parse(antaldagar);
                Console.WriteLine("Hur många kilometer kommer du att köra?");
                string antalkm = Console.ReadLine();
                double doublekm = double.Parse(antalkm);
                double summa = 300 + (1 * doublekm) + ((intdagar - 1)) * 500;
                Console.WriteLine("Det kommer att kosta " + summa + "kr" + " att hyra bilen.");
            }
            catch
            {
                Console.WriteLine("Använd endast siffror och kommatecken (inte punkt.)");
            }
        }
    }
}
