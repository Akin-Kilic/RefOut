using System;

namespace RefOut
{
    class Program
    {
        static void Main()
        {
            //ilk  baştta bir değişken ve iki tane metot oluşturalım.
            int sayimiz = 3;
            //oluşturduğumuz değişkeni ekrana yazdıralım.
            Console.WriteLine("Başlangıç değeri: {0}", sayimiz);
            //oluşturduğumuz motodu çağırarak değişkenimizin değerini ekrana yazdıralım.
            Topla(sayimiz);
            Console.WriteLine("Topla() sonrası: {0}", sayimiz);
            //şimdide ref keyword lü metotdu çağırarak sonucu ekrana yazdıralım.
            Topla2(ref sayimiz);
            Console.WriteLine("Topla2() sonrası: {0}", sayimiz);

            //normal metodu çağırdığımızda int olarak tanımladığımız değer tipli sayı metot içindeki parametreye atanır
            //ve parametre üzerinde işlemler gerçekleşir bu yüzden asıl sayımızda değişiklik olmaz.
            //daha sonrasında ise ref keywordu ile kullandığımız metodu çağırdığımızda ise ref keywordu sayesinde
            //değer tipli olan int sayımız referans tip olarak davranarak oluşturduğumuz sayının ilk değeri değişir.
            //bunun nedeni ise değer tipler stack içerisinde ve referans tipler heap içerisinde saklanır.
            //Heap bölgesinde oluşturulan referans türlerine belleğin başlangıç adresi ile erişim sağlanır
            //ve herhangi bir yerde yapılan değişiklik verinin değişmesine neden olur.
            //ref anahtar kelimesini kullandığında başlangoç değerini vermen gerekirken
            //out anahtar sözcüğü ile ilk değeri ataman gerekmez.

        }

        static void Topla(int sayi)
        {
            sayi = sayi + sayi;
        }

        static void Topla2(ref int sayi)
        {
            sayi = sayi + sayi;
        }
    }
}
