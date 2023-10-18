using MediatorPattern.Lab_2.Abstract;
using MediatorPattern.Lab_2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_2.Concrete
{
    public class Student : AssignedCourseMember
    {
        //Student sınıfını intialize ederken içerisine CoreMediator tipinde bir parametre alacak. Aldığı bu parametreyi sınıf içerisinde kullanmadığımızda private bir üyeye atamadık. Sadece gelen parametreyi ata sınıfına göndermek için constructor'da çağırdık.
        public Student(CoreMediator coreMediator) : base(coreMediator)
        {
        }

        public string Name { get; set; }

        public void SendQuestion(string message)
        {
            Console.WriteLine($"{this.Name}: {message}");
        }

        public void ReceiveAnswer(string message)
        {
            Console.WriteLine($"Öğrencinin aldığı mesaj: {message}");
        }
    }
}
