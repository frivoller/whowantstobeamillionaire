using System;

class Program
{
    static void Main()
    {
        // Doğru cevap sayısını takip eden değişken
        int dogruCevapSayisi = 0;

        // 1. Soru
        Console.WriteLine("1 -> Hangi hayvan daha hızlıdır?");
        Console.WriteLine("a) Tavşan");
        Console.WriteLine("b) Kaplumbağa");
        Console.Write("Cevabınız (a/b): ");
        string cevap1 = Console.ReadLine().ToLower(); // Harf duyarlılığı olmaması için ToLower kullanıyoruz

        if (cevap1 == "a") // Doğru cevap: Tavşan
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru!");
        }
        else
        {
            Console.WriteLine("Yanlış!");
        }

        // 2. Soru
        Console.WriteLine("\n2 -> Dünya'nın uydusu hangisidir?");
        Console.WriteLine("a) Güneş");
        Console.WriteLine("b) Ay");
        Console.Write("Cevabınız (a/b): ");
        string cevap2 = Console.ReadLine().ToLower();

        if (cevap2 == "b") // Doğru cevap: Ay
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru!");
        }
        else
        {
            Console.WriteLine("Yanlış!");
        }

        // Eğer ilk iki soruda iki yanlış yaptıysa 3. soruya gerek yok
        if (dogruCevapSayisi < 2)
        {
            Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız.");
            return; // Program burada sonlanır
        }

        // 3. Soru (Eğer ilk iki sorudan 2 doğru varsa bu soru sorulur)
        Console.WriteLine("\n3 -> 2+21 işleminin sonucu kaçtır?");
        Console.WriteLine("a) 23");
        Console.WriteLine("b) 221");
        Console.Write("Cevabınız (a/b): ");
        string cevap3 = Console.ReadLine().ToLower();

        if (cevap3 == "a") // Doğru cevap: 23
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru!");
        }
        else
        {
            Console.WriteLine("Yanlış!");
        }

        // Yarışmacının sonucu
        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("\nTebrikler! Artık milyonersiniz!");
        }
        else
        {
            Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız.");
        }
    }
}
