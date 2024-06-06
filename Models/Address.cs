using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address
    {
        public int Id { get; set; }
        public  string AddressName { get; set; } // Logradouro
        public string Zip { get; set; }
        public string Neighborhood { get; set; }
        public string AddressType { get; set; } // Rua ou avenida (street or avenue)
        public string Complement { get; set; }
        public int Number { get; set; }
        public string Fu { get; set; } // UF (Unidade Federativa)
        public string City { get; set; }
    }
}
