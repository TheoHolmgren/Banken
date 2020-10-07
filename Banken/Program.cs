using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<Customer> Customers = new List<Customer>();  // Listan Customers skapas, med Customer som innehåll 
        static void Main(string[] args)
        {
            

            int choice = SelectMenuItem(); // SelectMenuItem är var du väljer vilket menyalternativ du ska använda 

            while (choice != 7) // Så länge valet inte är 7:an så spottar den ut listan efter varje val av menyalternativ
            {
                switch (choice) //Switch-sats, där 1 utav 7 utfall händer beroende på vilken siffra användaren väljer.

                {
                    case 1: //Utfall 1, om användaren väljer 1
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 1"); //Skriver ut att användaren valde 1
                        Console.WriteLine("Lägg till en användare i IndigoBanken"); //Ber användaren lägga till en användare i banken
                        Customer customer = new Customer(); //Skapar en ny kund
                        Console.Write("Ange namn: "); //Ber om kundens namn
                        customer.Name = Console.ReadLine(); //Sätter det angivna namnet på den skapade kunden
                        Customers.Add(customer); //Lägger till kunden i kundlistan
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        break; 
                    case 2: //Utfall 2, om användaren väljer 2
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 2"); //Skriver ut att användaren valde 1
                        Showallcustomers(); //Anropar funktionen Showallcustomers för att visa listan med alla användare
                        Console.Write("Ange vilket konto som ska tas bort: "); //Ber användaren välja vilket konto som skall tas bort
                        string x = Console.ReadLine(); //Tar in svaret i en sträng vid med namnet x
                        int y = int.Parse(x); //Gör om innehållet i x till en int o lägger det i variabeln y

                        Customers.RemoveAt(y); //Tar bort användaren på platsen y
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        break;
                    case 3: //Utfall 3, om användaren väljer 3
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 3"); //Skriver ut att användaren valde 3
                        Showallcustomers(); //Anropar funktionen Showallcustomers för att visa listan med alla kunder i
                        Console.WriteLine("Press any key to continue..."); //Stannar programmet tills det att användaren har tryckt på valfri knapp
                        Console.ReadKey();
                        Console.Clear(); //Rensar all output i konsollen så den är tom



                        break;
                    case 4: //Utfall 4, om användaren väljer 4
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 4"); //Skriver ut att användaren valde 4
                        Console.WriteLine("Vilken användare vill se sitt saldo? :"); //Frågar användaren vilken användare önskar se sitt saldo
                        int answer = Convert.ToInt32(Console.ReadLine()); //Omvandlar svaret till en int, sparar det i variabeln answer

                        Console.WriteLine(Customers[answer].ShowCustomer()); //Anropar funktionen ShowCustomer för den valda kunden 
                        Console.WriteLine("Press any key to continue..."); //Stannar programmet tills användaren tryckt på valfri knapp
                        Console.ReadKey();
                        Console.Clear(); //Rensar all output i konsollen så den är tom



                        break;
                    case 5: //Utfall 5, om användaren väljer 5
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 5"); //Skriver ut att användaren valde 5
                        Console.WriteLine("Vilket konto ska lägga till pengar? :"); //Frågar användaren vilket konto som ska lägga till pengar
                        int answer1 = Convert.ToInt32(Console.ReadLine()); //Tar svaret och omvandlar det till en int, sparar svaret i variabeln answer1
                        Console.WriteLine("Hur mycket pengar önskas lägga in? :"); //Frågar användaren hur mycket pengar de vill lägga in på sitt konto
                        int answermoney = Convert.ToInt32(Console.ReadLine()); //Tar svaret och omvandlar det till en int, sparar svaret i variabeln answermoney

                        Customers[answer1].Balance += answermoney; //Lägger till det antal pengar som användaren angav till det konto som användaren angav
                        Console.WriteLine("Ditt saldo är nu: " + Customers[answer1].Balance); //Visar saldot för den valda användaren
                        Console.WriteLine("Press any key to continue...");//Stannar programmet tills användaren trycker på valfri knapp
                        Console.ReadKey();
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        break;
                    case 6: //Utfall 6, om användaren väljer 6
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 6"); //Skriver ut att användaren valde 6
                        Console.WriteLine("Vilket konto ska ta ut pengar? :"); //Frågar användaren vilket konto som ska ta ut pengar
                        int answerwithdraw = Convert.ToInt32(Console.ReadLine()); //Tar svaret och omvandlar det till en int, sparar svaret i variablen answerwithdraw

                        Console.WriteLine("Hur mycket pengar önskas tas ut? :"); //Frågar användaren hur mycket pengar de vill ta ut
                        int withdrawalamount = Convert.ToInt32(Console.ReadLine()); //Tar svaret och omvandlar det till en int, sparar svaret i variablen withdrawalamount

                        if (withdrawalamount < Customers[answerwithdraw].Balance) //Om den valda summan är mindre än den valda kundens saldo
                        {
                            Customers[answerwithdraw].Balance -= withdrawalamount; //Subtrahera den valda summan från den valda kundens saldo
                            Console.WriteLine("Du tog ut: " + withdrawalamount); //Skriver ut hur mycket pengar användaren tog ut

                        } else if (withdrawalamount > Customers[answerwithdraw].Balance) //Om den valda summan är större än den valda kundens saldo
                        {
                            Console.WriteLine("Not enough money in the account"); //Skriver ut att användaren inte har nog högt saldo
                        }
                        Console.WriteLine("Press any key to continue..."); //Stannar programmet tills användaren trycker på valfri knapp
                        Console.ReadKey();
                        Console.Clear(); //Rensar all output i konsollen så den är tom

                        break;
                    case 7: //Utfall 7, om användaren väljer 7
                        Console.Clear(); //Rensar all output i konsollen så den är tom
                        Console.WriteLine("Användaren valde 7"); //Skriver ut att användaren valde 7
                        System.Environment.Exit(0); //Stänger av programmet                      
                        break;
                }
                choice = SelectMenuItem(); //Vilket menyalternativ användaren valde
            }
        }

        private static void Showallcustomers() //Visa alla kunder i listan Customers
        {
            for (int i = 0; i < Customers.Count; i++) //så länge i är mindre än antalet kunder i listan Customers, öka i med 1
            {
                Console.WriteLine(Customers[i].ShowCustomer()); //Skriv ut kunden med index i, kund 0, kund 1, kund 2 osv...
            }
        }

        private static int SelectMenuItem() //Visar alla menyalternativ
        {
            Console.WriteLine("1 : Lägg till en användare"); //Skriver ut 1 : Lägg till en användare
            Console.WriteLine("2 : Ta bort en användare"); //Skriver ut 2 : Ta bort en användare
            Console.WriteLine("3 : Visa alla befintliga användare"); //Skriver ut 3 : Visa alla befintliga användare
            Console.WriteLine("4 : Visa saldo för en användare"); //Skriver ut 4 : Visa saldo för en användare
            Console.WriteLine("5 : Gör en insättning för en användare"); //Skriver ut 5 : Gör en insättning för en användare
            Console.WriteLine("6 : Gör ett uttag för en användare"); //Skriver ut 6 : Gör ett uttag för en användare
            Console.WriteLine("7 : Avsluta programmet"); //Skriver ut 7 : Avsluta programmet
            Console.WriteLine("Skriv ditt val: "); //Skriver ut Skriv ditt val: 

            int choice = int.Parse(Console.ReadLine()); //Läser in användarens val
            return choice; //Returnerar valet

        }
    }
}
