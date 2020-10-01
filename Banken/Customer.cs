using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Customer //Klassen Customer
    {
        public string Name { get; set; } //Medlemsvariabel i klassen Customer
        public int Balance { get; set; } //Medlemsvariabel i klassen Customer

        public string ShowCustomer() //Medlemsmetod i klassen Customer
        {
            return Name + " med saldo: " + Balance; //Vad medlemsmetoden returnerar
        }
    }
}
