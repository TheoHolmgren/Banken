using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<Customer> Customers = new List<Customer>();  // Listan Customer skapas, med Customer som innehåll //
        static void Main(string[] args)
        {
            

            int choice = SelectMenuItem(); // SelectMenuItem är var du väljer vilket menyalternativ du ska använda //

            while (choice != 7) // Så länge valet inte är 7:an så spottar den ut listan efter varje val av menyalternativ
            {
                switch (choice) //Switch-sats

                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 1");
                        Console.WriteLine("Lägg till en användare i IndigoBanken");
                        Customer customer = new Customer();
                        Console.Write("Ange namn: ");
                        customer.Name = Console.ReadLine();
                        Customers.Add(customer);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 2");
                        Showallcustomers();
                        Console.Write("Ange vilket konto som ska tas bort: ");
                        string x = Console.ReadLine();
                        int y = int.Parse(x);

                        Customers.RemoveAt(y);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 3");
                        Showallcustomers();
                        
                        

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 4");
                        Console.WriteLine("Vilken användare vill se sitt saldo? :");
                        int answer = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(Customers[answer].ShowCustomer());
                        Console.Clear();


                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 5");
                        Console.WriteLine("Vilket konto ska lägga till pengar? :");
                        int answer1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hur mycket pengar önskas lägga in? :");
                        int answermoney = Convert.ToInt32(Console.ReadLine());

                        Customers[answer1].Balance += answermoney;
                        Console.WriteLine("Ditt saldo är nu: " + Customers[answer1].Balance);
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 6");
                        Console.WriteLine("Vilket konto ska ta ut pengar? :");
                        int answerwithdraw = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Hur mycket pengar önskas tas ut? :");
                        int withdrawalamount = Convert.ToInt32(Console.ReadLine());

                        if (withdrawalamount < Customers[answerwithdraw].Balance)
                        {
                            Customers[answerwithdraw].Balance -= withdrawalamount;
                            Console.WriteLine("Du tog ut: " + withdrawalamount);

                        } else if (withdrawalamount >= Customers[answerwithdraw].Balance)
                        {
                            Console.WriteLine("Not enough money in the account");
                        }
                        Console.Clear();

                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Användaren valde 7");
                        System.Environment.Exit(0);
                        Console.Clear();
                        break;
                }
                choice = SelectMenuItem();
            }
        }

        private static void Showallcustomers()
        {
            for (int i = 0; i < Customers.Count; i++)
            {
                Console.WriteLine(Customers[i].ShowCustomer());
            }
        }

        private static int SelectMenuItem()
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
            return choice;

        }
    }
}
