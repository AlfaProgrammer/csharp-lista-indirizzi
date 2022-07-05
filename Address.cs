using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Address
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int ZIP { get; set; }

        public static readonly List<Address> _addresses = new List<Address>();

        public void PrintAdresses()
        {
            foreach (var address in Address._addresses)
            {
                Console.WriteLine("##### Indirizzo #####");
                Console.WriteLine(address);
                Console.WriteLine("#", 15);
                Console.WriteLine();
            }
        }
    }
}
