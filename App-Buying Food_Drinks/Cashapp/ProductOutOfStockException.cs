using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashapp
{
    class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException()
            : base("Product is out of stock")
        {

        }
    }
}
