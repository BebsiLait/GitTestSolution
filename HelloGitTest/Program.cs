using System;

namespace HelloGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub!");
            Console.WriteLine("BebsiLait");

            Console.WriteLine("Programm starten (x)");
            
            string sEingabe = Console.ReadLine();


            if (sEingabe == "x")
            {
                startProgramm();
            }
            else
            {
                Console.WriteLine("Das Programm konnte leider nicht gestartet werden");
            }
        }

        private static void startProgramm()
        {
            Console.WriteLine("Produkt-Liste: ");
        }
    }
}
