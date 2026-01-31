using System;
using System.Collections.Generic;

namespace Konfigo.Model
{
    public class Configuration
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }

        public List<Component> Components { get; set; }
    }
}
