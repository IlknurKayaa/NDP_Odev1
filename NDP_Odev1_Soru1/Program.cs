/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Ödev1_Soru1
**				ÖĞRENCİ ADI............: İlknur KAYA
**				ÖĞRENCİ NUMARASI.......: B201210098
**                         DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/

using System;

namespace NDP_Odev1_Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dizi = new string[8, 8];
            int sayi;
            bool durum = true;
            Random rnd = new Random();
            int satir;
            int sutun;
            //8x8 elemanları 0 olan matris oluşturma
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    dizi[x, y] = "0";
                }
            }
            // ilk kale yerlestirilmesi baslangici;
            satir = rnd.Next(0, 8); // random satit degeri alma
            sutun = rnd.Next(0, 8); // random sutun degeri alma
            dizi[satir, sutun] = "K"; // alinan satir ve sutun degerlerine kale yerlestirme

            Console.WriteLine("0. matris "); // ilk yerlestirilen kale ile ilk matrisi ekrana yazma
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(dizi[x, y] + " ");
                }
                Console.WriteLine();
            }
            // ilk kale yerlestirilmesi sonu;

            // diğer kale yerlestirilmesi ;
            for (int m = 1; m < 8; m++) // ilk kale yerlestirilip yazildigi icin sayac 1 den basladi
            {

                satir = rnd.Next(0, 8); // random satir degeri alma
                sutun = rnd.Next(0, 8); // random sutun degeri alma 

                sayi = 0; // satir ve sutun kontrolunde kullanılacak sayının ilk deger atamasi

                while (durum == true) // sutun kontrolu baslangici
                {

                    for (int i = 0; i < 8; i++)
                    {

                        if (dizi[i, sutun] == "K") // sutunun herhangi bir satir degerinde K olma durumu
                        {
                            durum = false;
                            break;    // durum yanlis for dongusunden cik
                        }
                        else
                        {
                            durum = true; // sutun boşsa durum dogru

                        }
                        sayi++; // sutun bos oldukca sayiyi 1 arttir
                    }

                    if (durum == false) // durum yanlissa bu islemi yap
                    {
                        sutun = rnd.Next(0, 8); // sutun degerini degistir
                        durum = true; // durumu dogru yap ve while dongusunun basına don tekrar sutun araması yap
                    }


                    if (sayi == 8 && durum == true) // tum sutun bossa ve durum dogruysa bu islemi yap
                    {
                        break; // while dongusunden cik
                    }
                    sayi = 0; // donguden cikilmadiysa sayiyi sıfırla ve while dongusunun basına don
                }

                sayi = 0; // sayiya sıfır degeri ver
                while (durum == true) // satir kontrolu
                {

                    for (int i = 0; i < 8; i++)
                    {

                        if (dizi[satir, i] == "K") // satirin herhangi bir sutun degerinde K olma durumu
                        {
                            durum = false;
                            break;   // durum yanlis for dongusunden cik
                        }
                        else
                        {
                            durum = true;  // satir bossa durum dogru

                        }
                        sayi++;  // satir bos oldukca sayiyi 1 arttir
                    }

                    if (durum == false) // durum yanlissa bu islemi yap
                    {
                        satir = rnd.Next(0, 8); // satir degerini degistir
                        durum = true; // durumu dogru yap ve while dongusunun basına don tekrar satir araması yap
                    }


                    if (sayi == 8 && durum == true) // tum satir bossa ve durum dogruysa bu islemi yap
                    {
                        break; // while dongusunden cik
                    }
                    sayi = 0; // donguden cikilmadiysa sayiyi sıfırla ve while dongusunun basına don
                }

                dizi[satir, sutun] = "K"; // kontrol edilen satir ve sutun degerlerine K yaz

                Console.WriteLine(m + ". matris "); // yerleştirilen kalelerle birlikte her adımda matrisi yaz
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        Console.Write(dizi[x, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
