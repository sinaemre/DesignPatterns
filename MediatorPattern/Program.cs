using MediatorPattern.Lab_1.Concrete;
using MediatorPattern.Lab_1.Interface;
using MediatorPattern.Lab_1.Mediator.Concrete;
using MediatorPattern.Lab_1.Mediator.Interface;
using MediatorPattern.Lab_2.Concrete;
using MediatorPattern.Lab_2.Mediator;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab - 1
            //IChatMediator chatMediator = new ChatMediator();

            //IUser burak = new BasicUser(chatMediator, "beast");
            //IUser sina = new GoldUser(chatMediator, "boss");
            //IUser huseyin = new BasicUser(chatMediator, "goat");

            //chatMediator.AddUser(burak);
            //chatMediator.AddUser(sina);
            //chatMediator.AddUser(huseyin);

            //sina.SendMessage("Selam arkadaşlar. Elleri görelim...");
            #endregion

            #region Lab - 2
            CoreMediator coreMediator = new CoreMediator();

            Teacher teacher = new Teacher(coreMediator);
            teacher.Name = "Ord. Prof. Sina Emre BEKAR";


            Student alptekin = new Student(coreMediator);
            alptekin.Name = "Alptekin Öztürk";

            Student goktug = new Student(coreMediator);
            goktug.Name = "Göktüğ Yılmaz";

            coreMediator.Students = new List<Student> { alptekin, goktug };

            Console.WriteLine("Senaryo - 1");

            alptekin.SendQuestion("Kurs ne zaman bitecek?");
            teacher.AnswerQuestion("Çok zoru soru. Bilmiyorum!!!", alptekin);

            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Senaryo - 2");

            teacher.ReceiveQuestion("Ne soriyim hocam?", goktug);
            teacher.AnswerQuestion("Bilmiyorum Göktuğ. Canının istediğini sorabilirsin? ", goktug);
            #endregion
        }
    }
}