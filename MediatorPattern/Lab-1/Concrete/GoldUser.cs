using MediatorPattern.Lab_1.Interface;
using MediatorPattern.Lab_1.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_1.Concrete
{
    public class GoldUser : IUser
    {
        private readonly IChatMediator _chatMediator;
        private readonly string _userName;

        public GoldUser(IChatMediator chatMediator, string userName)
        {
            _chatMediator = chatMediator;
            _userName = userName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanıcı Tipi: Gold\nKullanıcı Adı: {_userName}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
