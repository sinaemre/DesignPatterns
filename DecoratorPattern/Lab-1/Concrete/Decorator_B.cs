using DecoratorPattern.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab_1.Concrete
{
    public class Decorator_B : IBilesen
    {
        private readonly IBilesen _bilesen;

        public Decorator_B(IBilesen bilesen) 
        {
            _bilesen = bilesen;
        }
        public string Operation()
        {
            return _bilesen.Operation() + "RPA projeleri geliştiriyorum.";
        }
        public string EkDavranis() => "Yükek lisans yapıyorum.";
    }
}
