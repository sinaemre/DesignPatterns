using MediatorPattern.Lab_1.Interface;
using MediatorPattern.Lab_1.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_1.Concrete
{
    public class BasicUser : IUser
    {
        IChatMediator _chatMediator;
        string _userName;

        public BasicUser(IChatMediator chatMediator, string userName)
        {
            _chatMediator = chatMediator;
            _userName = userName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanıcı tipi: Basic\nKullanıcı Adı: {_userName}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
