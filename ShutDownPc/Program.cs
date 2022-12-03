using System;

namespace Shut_Down_Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilgisayarı kapatmak istediğinize emin misiniz? (E/H)");
            string response = Console.ReadLine().ToUpper();

            if (response == "E")
            {
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                Console.WriteLine("Bilgisayar kapatılıyor...");
            }
            else if (response == "H")
            {
                Console.WriteLine("Kapatma iptal edildi.");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
            }
        }
    }
}