using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.DTOPattern.ViewModel.Product
{
    public class ProductResponseGet
    {
        public string Id { get;  set; }

        public string Name { get;  set; }

        public int Quantity { get;  set; }
    }

    public class ProductRequestGet
    {
        public string Id { get; private set; }

    }
}
