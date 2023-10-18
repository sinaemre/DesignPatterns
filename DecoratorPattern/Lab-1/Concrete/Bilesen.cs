using DecoratorPattern.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab_1.Concrete
{
    public class Bilesen : IBilesen
    {
        public string Operation() => "Çalıştığım firma için ";
    }
}
