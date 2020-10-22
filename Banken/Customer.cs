using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Customer //Klassen Customer
    {
        public Customer() //E tom konstruktor
        {

        }
        public Customer(string Name) //En konstruktor som sätter namnet
        {
            this.Name = Name;
            this.Balance = 0;
        }
        public string Name { get; set; } //Medlemsvariabel i klassen Customer
        public int Balance { get; set; } //Medlemsvariabel i klassen Customer

        public string ShowCustomer() //Medlemsmetod i klassen Customer
        {
            return Name + " med saldo: " + Balance; //Vad medlemsmetoden returnerar
        }
    }
}
