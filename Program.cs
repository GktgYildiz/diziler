using System;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DİZİ TANIMLAMA
            string[] renkler = new string[5]; //5 adet elemanı olan renkler dizisi -not: elemanlar belli değil
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };
            int[] dizi;
            dizi=new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını alan program

            Console.Write("lütfen dizinin eleman sayısını giriniz: ");
            int diziuzunlugu=int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("lütfen {0}. sayıyı giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            
                toplam += sayi;
                Console.WriteLine("ortalama: " + toplam/diziuzunlugu);


          
       
        }
    }
}
