using MediatorPattern.Lab_2.Abstract;
using MediatorPattern.Lab_2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_2.Concrete
{
    public class Teacher : AssignedCourseMember
    {
        public Teacher(CoreMediator coreMediator) : base(coreMediator)
        {
        }

        public string Name { get; set; }

        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine($"{student.Name} öğrencisinden gelen soru: {question}");
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine($"{student.Name} öğrencisin sorduğu soruya verilen yanıt: {answer}");
        }
    }
}
