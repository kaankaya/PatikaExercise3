using System;

namespace Patika
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
             Switch-case yapısını kullanmak, bu tür bir uygulamayı hayata geçirmek için daha doğru bir yöntem. Bunun nedeni, switch-case yapısının okunabilirliğinin daha kolay olmasıdır.
             Ek olarak birçok koşulun kontrol edilmesi gerektiğinde if-else yapıları karmaşık ve okunması zor olabilirken, 
            switch-case yapısı daha anlaşılır bir yapıda.
             */
            //Meyve fiyat değerleri tanımlama
            int elma = 2;
            int armut = 3;
            int cilek = 2;
            int muz = 3;
            int diger = 4;
            //karşılama ekranı bilgileri ve fiyat değerlerinin eklenmesi
            Console.WriteLine("Rüya Manavina Hos Geldiniz !");
            Console.WriteLine($"Elma = {elma} TL ");
            Console.WriteLine($"Armut = {armut} TL ");
            Console.WriteLine($"Cilek = {cilek} TL ");
            Console.WriteLine($"Muz = {muz} TL ");
            Console.WriteLine($"Diğer Bütün Meyveler = {diger} TL ");

            Console.Write("Hangi Meyveyi satın almak istersiniz? (Elma/Armut/Cilek/Muz/Diğer): ");
            //Kullanıcıdan veri Al - Girilen verideki tüm harfleri küçült toLower ile
            string fruit = Console.ReadLine().ToLower();
            //girilen veri ile mevcut listedeki veri eşit mi eşit ise mesajı ve fiyatı göster
            if(fruit == "elma")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {elma} TL ");
            }else if(fruit == "armut")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {armut} TL");
            }
            else if (fruit == "cilek")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {cilek} TL");
            }
            else if (fruit == "muz")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {muz} TL");
            }
            else
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {diger} TL");
            }

            Console.WriteLine("---------------------------");
            //Switch Case ile Yapımı
            //karşılama ekranı bilgileri ve fiyat değerlerinin eklenmesi
            Console.WriteLine("Rüya Manavina Hosgeldiniz ! ");
            Console.WriteLine($"Elma = {elma} TL ");
            Console.WriteLine($"Armut = {armut} TL ");
            Console.WriteLine($"Cilek = {cilek} TL ");
            Console.WriteLine($"Muz = {muz} TL ");
            Console.WriteLine($"Diğer Bütün Meyveler = {diger} TL ");

            Console.Write("Hangi Meyveyi satın almak istersiniz? (Elma/Armut/Cilek/Muz/Diğer): ");
            //Kullanıcıdan veri Al - Girilen verideki tüm harfleri küçült toLower ile
            string meyve = Console.ReadLine().ToLower();
            //girilen veri kontrol

            switch (meyve)
            {
                case "elma":
                    Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {elma} TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {armut} TL");
                    break;
                case "cilek":
                    Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {cilek} TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {muz} TL");
                    break;
                default:
                    Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {diger} TL");
                    break;

            }

        }
    }
}