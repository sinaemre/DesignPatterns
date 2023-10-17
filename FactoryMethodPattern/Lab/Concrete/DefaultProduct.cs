using FactoryMethodPattern.Lab.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab.Concrete
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom() => "Shipping isn't avaliable...";
    }
}
