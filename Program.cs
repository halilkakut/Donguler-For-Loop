﻿using System;

namespace Donguler_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar tek olan sayıları ekrana yazdır.
            // Console.WriteLine("Bir Sayı giriniz");
            // int sayac = int.Parse(Console.ReadLine());

            // for (int i = 1; i < sayac; i++)
            // {
            //     if (i % 2 == 1){
            //         Console.WriteLine(i);
            //     }
            // }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde ki toplamları
            // int tekToplam = 0;
            // int ciftToplam = 0;

            // for (int j=1; j <= 1000; j++)
            // {
            //     if(j % 2 == 1){
            //         tekToplam+=j;
            //     }else{
            //         ciftToplam+=j;
            //     }
            // }

            // Console.WriteLine("Tek Toplam = " +tekToplam);
            // Console.WriteLine("Çift Toplam = " +ciftToplam);

            //break ,continue

            // for(int t=1; t<=10; t++)
            // {
            //     if(t == 4)
            //         break; 
            //     Console.WriteLine(t);
            // }

            // for(int t=1; t<=10; t++)
            // {
            //     if(t == 4)
            //         continue; 
            //     Console.WriteLine(t);
            // }
            Console.WriteLine("******While******");
            //While 1 den başlayarak console dan girilen sayıya kadar ortalama hesaplama

            Console.Write("Bir Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                 toplam+=sayac;
                 sayac++;
            }

            //Console.WriteLine(toplam / sayi);
            // 'a' dan 'z' ye kadar karakter yazma
            
            // char character = 'a';

            // while (character < 'z')
            // {
            //      Console.Write(character);
            //      character++;
            // }

            Console.WriteLine("******Foreach******");
            string[] cars = {"BMW","Ford","Toyota","Mercedes"};

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
