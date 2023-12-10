using System;

class Program
{
    static void Main()
    {//kullanıcan sayı al.
        Console.Write("Bir sayı girin: ");
        if (int.TryParse(Console.ReadLine(), out int kullaniciSayisi))
        {//teklerimi çiftlermi toplansın.
            Console.Write("Hangi tür sayıları toplamak istersiniz? (tek/cift): ");
            string tur = Console.ReadLine().ToLower();

            if (tur == "tek" || tur == "cift")
            {
                int toplam = 0;

                for (int i = 1; i <= kullaniciSayisi; i++)//i yi 1'e eşitldim.
                {
                    if (tur == "tek" && i % 2 != 0)// türü tek ise i mod 2 .
                        toplam += i;
                    else if (tur == "cift" && i % 2 == 0) // türü çift ise i mod 2.
                        toplam += i;
                }

                Console.WriteLine($"1 ile {kullaniciSayisi} arasındaki {tur} sayıların toplamı: {toplam}");
            }
            else// hata mesajı.
            {
                Console.WriteLine("Geçersiz tür. 'tek' veya 'cift' olarak giriş yapın.");
            }
        }
        else
        {// hata mesajı.
            Console.WriteLine("Geçersiz sayı girişi. Lütfen bir tam sayı girin.");
        }
    }
}
