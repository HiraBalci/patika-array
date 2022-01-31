using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };
            int[] dizi;
            dizi = new int[3];
            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[2] = 10;
            Console.WriteLine(dizi[2]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ort. hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz : ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }
                Console.WriteLine("ortalama:"+toplam/diziUzunlugu);
            
        }
    }
}
