using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_10_2019_Cevre_Alan_Hesaplamaları
{
    class Program
    {
        static void Main(string[] args)
        {
        baslangıc:
            Console.Clear();
            int s1, s2;
            char secim;
            Console.WriteLine("--- Çevre ve Alan Hesaplama ---");
            Console.WriteLine();
            Console.WriteLine("Hesaplatmak İstediğiniz Şekli Seçiniz \nKare(k): \nDikdörtgen(d) ");
            secim = char.Parse(Console.ReadLine());
            switch (secim)
            {
                case 'k':
                    Console.WriteLine("--Kareyi Seçtiniz--");
                    Console.WriteLine("A kenarını Giriniz: ");
                    s1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yapacağınız İşlemi Seçiniz: \nAlan(a)\nÇevre(c)");
                    secim = char.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 'a':
                            Console.WriteLine("Alanı: {0}", s1 * s1);
                            break;
                        case 'c':
                            Console.WriteLine("Çevresi: {0}", s1 * 4);
                            break;
                    }
                    break;

                case 'd':
                    Console.WriteLine("--Dikdörtgeni seçtiniz--");
                    Console.WriteLine("A Kenarını Giriniz: ");
                    s1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("B Kenarını Giriniz: ");
                    s2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yapacağınız İşlemi Seçiniz: \nAlan(a)\nÇevre(c)");
                    secim = char.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 'a':
                            Console.WriteLine("Alanı: {0}", s1 * s2);
                            break;
                        case 'c':
                            Console.WriteLine("Çevresi: {0}", (s1 * 2) + (s2 * 2));
                            break;
                    }
                    break;
            }
                    Console.WriteLine("Yeni bir işleme devam etmek istiyor musunuz? Evet(e) - Hayır(h)");
                    secim = char.Parse(Console.ReadLine());
                    if (secim == 'e')
                    {
                        goto baslangıc;
                    }
                    else
                    {
                        Console.WriteLine("İşlem Bitmiştir");
                    }
            Console.Read();
        }
    }
}
