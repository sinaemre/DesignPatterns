using TheChainfOfResponsibility.Lab_1.Abstract;
using TheChainfOfResponsibility.Lab_1.Concrete;

namespace TheChainfOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zincirin halkalarını tanımlayalaım.
            PlayerHandler aviPlayer = new HandlerAvi();
            PlayerHandler mp3Player = new HandlerMP3();
            PlayerHandler mp4Player = new HandlerMP4();

            //Zinciri oluşturuyoruz
            mp3Player.NextHandler = mp4Player;
            mp4Player.NextHandler = aviPlayer;

            //İstekleri zincirin ilk halkasına gönderiyoruz.
            mp3Player.Player("video.mpg");
            mp3Player.Player("video.avi");
            mp3Player.Player("video.mp3");
            mp3Player.Player("video.mp4");
        }

    }
}