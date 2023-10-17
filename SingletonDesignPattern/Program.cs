using SingletonDesignPattern.Lab_1;
using SingletonDesignPattern.Lab_2;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab - 1
            //Aşağıdaki kodu etkinleştirdiğimizde Constroctor bize kızdı çünkü erişilebilir durumda değil. Teorik oalrakt söylediğimzi gibi singleton ile üretilen nesneleri uygulamanın herhangi bir yerinde çağırabiliriz lakin yeniden üretemeyiz.
            //SystemManager systemManager = new SystemManager();

            var systemManager = SystemManager.CreateSystemManagerObject(); //Bu custom mtehod vasıtasıyla bir SystemManager.cs sınfıından bir nesne sınıfın içerisinde kontrollü bir şekilde üretilecek ve bize bura geri dönülecek.

            systemManager.CreateLog(); //systemManager değişkeni üzerinden SystemManager.cs sınıfı içerisinde bulunan CreateLog() methoduna eriştim. Normalde bu method instance method olduğundan ona nesnenin örneklemi üzerinden erişebildim.
            #endregion

            #region Lab - 2
            Console.WriteLine("Sonuç: " + SingletonClass.SingletonObject.Toplam(3,4));

            #endregion
        }
    }
}