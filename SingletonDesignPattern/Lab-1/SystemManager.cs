using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Lab_1
{
    public class SystemManager
    {
        private static SystemManager _systemManager;
        private SystemManager() { } //Buradaki amaç bu sınıfın dışarıdan erişilerek örneklem alınmasını engellemektir. 

        //Sınıfın örneklemini dışarıda alamayacağız çünkü constructor'ı private yaptık. Bunun yerine nesneyi sınıfın kendi içerisinde kontrollü bir şekilde custom bir method ya da property üzerinden nesnein üretimini kontrol altına alarak üretilmesini temin ettik.
        public static SystemManager CreateSystemManagerObject() 
        {
            //Uygulamanın herhangi bir yerinde "SystemManager." diyerek CreateSystemManagerObject() methodunu çağırabilirim bu method da bana SystemManager sınıfının örneklemini bir şart doğrultusunda yaratır ya da var olanı teslim eder.
            if (_systemManager == null) //eğer _systemManager field'ın içerisi boşsa şart tutar
            {
                _systemManager = new SystemManager(); //nesne üretilir
            }
            //eğer ki nesnesi zaten dolu ise direk bize onu teslim eder
            return _systemManager; //nesne dönülür
        }


        public void CreateLog() => Console.WriteLine("A log was created...");
    }
}
