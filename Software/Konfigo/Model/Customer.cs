using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konfigo.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } // može i FirstName/LastName ako želiš
        public string Email { get; set; }
    }
}

