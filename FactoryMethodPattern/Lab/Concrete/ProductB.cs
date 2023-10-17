using FactoryMethodPattern.Lab.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab.Concrete
{
    public class ProductB : IProduct
    {
        public string ShipFrom() => "From Columbia...";
    }
}
