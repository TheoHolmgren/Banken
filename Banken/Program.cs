using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<int> Customers = new List<int>();
        static void Main(string[] args)

        switch(choice)

        {
            case 1:

                break;
        }

        {
            SelectMenuItem();
        }

        private static void SelectMenuItem()
        {
            Console.WriteLine("1 : Lägg till en användare");
            Console.WriteLine("2 : Ta bort en användare");
            Console.WriteLine("3 : Visa alla befintliga användare");
            Console.WriteLine("4 : Visa saldo för en användare");
            Console.WriteLine("5 : Gör en insättning för en användare");
            Console.WriteLine("6 : Gör ett uttag för en användare");
            Console.WriteLine("7 : Avsluta programmet");
            Console.WriteLine("Skriv ditt val: ");

            int choice = int.Parse(Console.ReadLine());
        }
    }
}
