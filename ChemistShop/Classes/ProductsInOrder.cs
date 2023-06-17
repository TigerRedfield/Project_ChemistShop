using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistShop.Classes
{
    public class ProductsInOrder : Entity.Medicines
    {
        public int Count { get; set; }
        public int Costing { get; set; }
    }
}
