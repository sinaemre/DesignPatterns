using FactoryMethodPattern.Lab.Creator;
using FactoryMethodPattern.Lab.Interface;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCreator creator = new ProductCreator();
            IProduct product;

            for (int month = 1; month <= 12; month++)
            {
                product = creator.FactoryMethod(month);
                Console.WriteLine("Product came " + product.ShipFrom());
            }
        }
    }
}