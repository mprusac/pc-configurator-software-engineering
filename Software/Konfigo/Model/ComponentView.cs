using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konfigo.Model
{
    public class ComponentView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }


        public int ComponentTypeId { get; set; }


        public string Manufacturer { get; set; }
        public string Specifications { get; set; }

        public int CompatibilityGroup { get; set; }


    }
}