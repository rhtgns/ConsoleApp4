using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı al
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi;

        
        while (!int.TryParse(Console.ReadLine(), out sayi))
        {
            Console.Write("Geçerli bir sayı giriniz: ");
        }

        // Sayının 10'a eşit, küçük veya büyük olup olmadığını kontrol et
        if (sayi == 10 && sayi % 2 == 0 )
        {
            Console.WriteLine("Girdiğiniz sayı 10'a eşittir ve çifttir ");
        }
        else if (sayi < 10  )
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
        }

        // Sayının çift mi tek mi olduğunu kontrol et
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı tektir.");
        }
    }
}
