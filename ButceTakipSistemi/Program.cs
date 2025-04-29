namespace Odev._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aySonuBakiye = 0;
            Console.WriteLine("lütfen ay numarasını giriniz(1-12): ");
            int ayNo = Convert.ToInt32(Console.ReadLine());

            if (ayNo < 1 || ayNo > 12)
            {
                Console.WriteLine("GEÇERSİZ AY NUMARASI GİRDİNİZ.");
                return;
            }

            string[] aylar = { "Ocak" , "Şubat" , "Mart","Nisan","Mayıs","Haziran" +
                               "Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};

            Console.WriteLine($"{aylar[ayNo - 1]} ayı için işlem yapıyorsunuz.\n");

            Console.Write("Lütfen başlangıç bakiyenizi giriniz: ");
            aySonuBakiye = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Başlangıç bakiyeniz: {aySonuBakiye:C}\n");
        Islemler:
            Console.WriteLine("işlem seçiniz: ");
            Console.WriteLine("1: gelir ekle");
            Console.WriteLine("2: gider ekle ");
            Console.WriteLine("3: bakiye görüntüle");
            Console.WriteLine("seçiminiz: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("gelir tutarı nedir: ");
                    double gelir = Convert.ToDouble(Console.ReadLine());
                    aySonuBakiye += gelir;
                    Console.WriteLine($"gelir eklenmiş yeni bakiye: {aySonuBakiye:C}\n");
                    goto Islemler;

                case "2":
                    Console.WriteLine("gider tutarı nedir: ");
                    double gider = Convert.ToDouble(Console.ReadLine());
                    aySonuBakiye -= gider;
                    Console.WriteLine($"gider düşülmüş yeni bakiye: {aySonuBakiye:C}\n");
                    goto Islemler;

                case "3":
                    Console.WriteLine($"\n{aylar[ayNo - 1]} ayı sonundaki bakiyeniz: {aySonuBakiye:C}");

                    if (aySonuBakiye < 0)
                    {
                        Console.WriteLine("bu ay ödemeniz gereken borçlarınız var!");
                    }
                    break;

                default:
                    Console.WriteLine("geçersiz seçim! Lütfen 1 , 2 veya 3 tuşuna basınız.\n");
                    goto Islemler;
            }
            Console.WriteLine("\n işlem tamamlandı.");




        }
    }
}
