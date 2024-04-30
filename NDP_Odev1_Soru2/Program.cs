/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Ödev1_Soru2
**				ÖĞRENCİ ADI............: İlknur KAYA
**				ÖĞRENCİ NUMARASI.......: B201210098
**                         DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/

using System;

namespace NDP_Odev1_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            // degiskenler tanimlandi.
            int secim;
            int indis;
            int durum = 0;
            string dizin, kelime, arakelime;
            string[] metin = new string[10]; // 3. secimin paragraf girdisi alabibilmesi icin dizi tanimlandi.
            int kontrol = 0;
            string harf = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ";

            do
            {
                // menu ve secenekler verildi secim istendi.
                Console.WriteLine("       Menü");
                Console.WriteLine("1) String bir değişkende, string değer substring kullanmadan ara");
                Console.WriteLine("2) String bir değişkende, string değer substring kullanarak ara");
                Console.WriteLine("3) Alfabenin karakterlerini bir stringde ara kaç adet geçiyor bul ve çiz.");
                Console.Write("Seçiminiz=");
                secim = Convert.ToInt32(Console.ReadLine()); // girilen secim degeri int e donusturuldu.
                if (secim == 1) // eger secim 1 ise bu islemler yapildi.
                {
                    Console.Write("Aranacak kelime= ");
                    arakelime = Console.ReadLine(); // aranacak kelime alindi.
                    arakelime = arakelime.ToLower(); // aranacak kelimenin butun harfleri kucultuldu.
                    Console.Write("Karakter dizini= ");
                    dizin = Console.ReadLine(); // kelimenin aranacağı cumle alindi.
                    dizin = dizin.ToLower(); // cumlenin butun harfleri kucultuldu.
                    indis = dizin.IndexOf(arakelime); // cumlenin icinde kelime arandi.
                    while (indis != -1) // kelime oldugu surece bu islemi yap.
                    {
                        Console.WriteLine("Kelime " + arakelime + " indis : " + indis); // kelimenin indisi yazdirildi.
                        indis = dizin.IndexOf(arakelime, indis + 1);
                        durum++; // durum kontrol degiskenini kelime oldugu muddetce arttir.
                    }
                    if (durum == 0) // durum kontrol degiskeni ilk degerinde (0) kaldiysa bu islemi yap.
                    {
                        Console.WriteLine("Kelime karakter dizininde bulunmuyor."); // kelime karakter dizininde bulunamadi.
                    }
                    durum = 0; // durum kontrol degiskeni sifirlandi.
                }
                if (secim == 2) // eger secim 2 ise bu islemler yapildi.
                {
                    Console.Write("Aranacak kelime= ");
                    arakelime = Console.ReadLine(); // aranacak kelime alindi.
                    arakelime = arakelime.ToLower(); // aranacak kelimenin harfleri kucultuldu.
                    Console.Write("Karakter dizini= ");
                    dizin = Console.ReadLine(); // karakter dizini alindi.
                    dizin = dizin.ToLower(); // alınan karakter dizininin harfleri kucultuldu.
                    if (arakelime.Length <= dizin.Length) // aranan kelime cumlenin uzunlugundan kucuk ya da esitse bu islem yaptirildi.
                    {
                        for (int i = 0; i < dizin.Length; i++)
                        {

                            if (dizin.Length - i >= arakelime.Length)
                            {
                                kelime = dizin.Substring(i, arakelime.Length); // kelime cumlenin icinde arandi.
                                if (kelime == arakelime) // kelime bundu ise bu islemi yap.
                                {

                                    Console.WriteLine("Kelime " + arakelime + " indis : " + i);
                                    durum++; // durum kontrol degiskenini arttitç
                                }

                            }


                        }
                        if (durum == 0) // durum kontrol degiskeni ilk degerinde (0) kaldi ise bu islemi yap.
                        {
                            Console.WriteLine("Aranan kelime karakter dizininde bulunmuyor.");
                        }
                        durum = 0; // durum kontrol degiskenini sifirla.
                    }
                    else // aranan kelime cumlenin uzunlugundan kucuk ya da esit degilse bu islem yaptirildi.
                    {
                        Console.WriteLine("Aranan kelime karakter dizininden uzun olamaz.");
                    }

                }
                if (secim == 3)
                {

                    Console.Write("Karakter dizini= ");
                    dizin = ""; // cumlenin ilk degeri atandi.
                    for (int i = 0; i < 10; i++)
                    {
                        metin[i] = Console.ReadLine(); // paragraf seklinde giris alabilmek icin donguye sokuldu.
                        kontrol = metin[i].Length; // kontrol degiskeni satirdaki degeri tuttu.
                        if (kontrol == 0) // kontrol degiskeni o satir bos birakildi ise 0 degeri aldi.
                        {
                            break; // for dan cikildi.
                        }


                    }

                    for (int a = 0; a < 10; a++)
                    {

                        dizin = string.Concat(dizin + metin[a]); // alinan paragraf tarzindaki yazi dizin degerimde birlestirildi.
                        dizin = dizin.ToUpper(); // cumlenin hepsi buyuk harfe donusturuldu.

                    }

                    char[] mdizin, hdizin;
                    int[] harfler = new int[32];

                    hdizin = harf.ToCharArray(); // harflerimin dizisi olusturuldu.
                    mdizin = dizin.ToCharArray(); // cumlemin dizisi olusturuldu.

                    for (int i = 0; i < harfler.Length; i++)
                    {
                        harfler[i] = 0; // harflerin hepsine en basta 0 degeri atandi.
                    }

                    Console.WriteLine("Karakter Sayısı   " + "Grafik Gösterimi");
                    for (int j = 0; j < hdizin.Length; j++)
                    {
                        for (int k = 0; k < mdizin.Length; k++)
                        {
                            if (hdizin[j] == mdizin[k]) // harf cumlede bulundu ise 
                            {
                                harfler[j] = harfler[j] + 1; // harfler dizimdeki deger 1 arttirildi.
                            }
                        }
                    }

                    Console.WriteLine("-----------------------------------------------------");
                    for (int n = 0; n < harfler.Length; n++)
                    {
                        Console.Write(hdizin[n] + " sayısı: "); // harfler yazildi.
                        Console.Write(harfler[n] + " "); // harfin kac tane bulundugu yazildi.
                        for (int m = 0; m < harfler[n]; m++)
                        {
                            Console.Write("*"); // harflerin bulundugu sayi kadar yildiz yazildi.
                        }
                        Console.WriteLine();


                    }


                }
                if (secim != 1 && secim != 2 && secim != 3)
                {
                    Console.WriteLine("Hatalı giriş yapıldı."); // secimde farkli bir sayi secilirse hata ver.
                }
            } while (secim == 1 || secim == 2 || secim == 3);
        }
    }
}
