using DecoratorPattern.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab_1.Concrete
{
    public class Decorator_A : IBilesen
    {
        private readonly IBilesen _bilesen;

        public Decorator_A(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }


        public string Operation() => _bilesen.Operation() + "yazımlı tanımlı ağlar projesi geliştiriyorum.";
    }
}
