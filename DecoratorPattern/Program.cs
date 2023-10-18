using DecoratorPattern.Lab_1.Clients;
using DecoratorPattern.Lab_1.Concrete;
using DecoratorPattern.Lab_1.Interface;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBilesen bilesen = new Bilesen();
            Decorator_A decorator_A = new Decorator_A(bilesen);
            Decorator_B decorator_B = new Decorator_B(bilesen);

            Decorator_A decorator_A2 = new Decorator_A(decorator_B);


            Client.Display("1. Ham Hali => ", bilesen);
            Client.Display("2. Ham Hali(dekoratör a ile dekore edildi) => ", decorator_A);
            Client.Display("3. Ham Hali(dekoratör b ile dekore edildi) => ", decorator_B);
            Client.Display("4. Ham hali(önce dekoratör b ile sonra dekoratör a ile dekore edildi) => ", decorator_A2);
            Client.Display($"Ek davranışlı hali => {decorator_B.EkDavranis()}", decorator_B);


        }
    }
}