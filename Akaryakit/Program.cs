using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double dizel = 23.12, benzin = 19.24, lpg = 16.07;
            double dizelTank = 1000, benzinTank = 1000, lpgTank = 1000;
            double satisMiktari = 0;
            char anaMenuSecim = '0', altMenuSecim = '0', akaryakitFiyatGuncelle = '0', akaryakitSatisTipi = '0';

            // Main Menu Create
            MENU:
            Console.WriteLine("Akaryakıt Satış Takip");
            Console.WriteLine("---------------------");
            Console.WriteLine("1- Birim Fiyat Göster");
            Console.WriteLine("2- Birim Fiyat Güncelle");
            Console.WriteLine("3- Akaryakıt Satış");
            Console.WriteLine("4- Depo Durumunu Göster");
            Console.WriteLine("5- Toplam Satışları Göster");
            Console.WriteLine("6- Çıkış Yap");

            Console.Write("Seçiminizi Yapınız: [1,2,3,4,5,6]: ");
            anaMenuSecim = Convert.ToChar(Console.ReadLine());
            if (anaMenuSecim == '1')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz 1");
                Console.WriteLine("---Birim Fiyatlar Listesi---");
                Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);
                Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                Console.WriteLine("LPG (L):{0} TL/Litre", lpg);
                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menü 2: Programı Kapat]: ");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız (1,2)");
                    goto ALTMENU;
                }
            }
            else if (anaMenuSecim == '2')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz 2");
                Console.WriteLine("---Birim Fiyatlar Güncelleme---");
                AKARYAKITTIPI:
                Console.WriteLine("Akaryakıt tipini seçin [D,B,L]: ");
                akaryakitFiyatGuncelle = Convert.ToChar(Console.ReadLine());
                if(akaryakitFiyatGuncelle=='D' || akaryakitFiyatGuncelle == 'd')
                {
                    Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);
                    Console.Write("Dizel yakıt için yeni fiyat giriniz: ");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Yeni Dizel Fiyatı (D):{0} TL/Litre", dizel);
                }
                else if (akaryakitFiyatGuncelle == 'B' || akaryakitFiyatGuncelle == 'b')
                {
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                    Console.Write("Benzin yakıt için yeni fiyat giriniz: ");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Yeni Benzin Fiyatı (B):{0} TL/Litre", benzin);
                }
                else if (akaryakitFiyatGuncelle == 'L' || akaryakitFiyatGuncelle == 'l')
                {
                    Console.WriteLine("LPG (L):{0} TL/Litre", lpg);
                    Console.Write("LPG yakıt için yeni fiyat giriniz: ");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Yeni LPG Fiyatı (L):{0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine("Hatalı seçim [D,B,L]: ");
                    goto AKARYAKITTIPI;
                }
                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menü 2: Programı Kapat]: ");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız (1,2)");
                    goto ALTMENU;
                }
            }
            else if (anaMenuSecim == '3')
            {
                Console.Clear();
                Console.WriteLine(">>> Seçiminiz 3");
                Console.WriteLine("---Akaryakıt Satış İşlemleri---");
                AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt tipini seçin [D,B,L]: ");
                akaryakitSatisTipi = Convert.ToChar(Console.ReadLine());
                if(akaryakitSatisTipi=='D' || akaryakitSatisTipi == 'd')
                {
                    if (dizelTank == 0)
                    {
                        Console.WriteLine("Yakıt tankında dizel yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık dizel yakıt satacaksınız: ");
                        satisMiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizelTank < satisMiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre dizel vardır! İşlem yapılamadı", dizelTank);
                            goto MENU;
                        }
                        else if (satisMiktari <= dizelTank)
                        {
                            dizelTank = dizelTank - satisMiktari;
                            Console.WriteLine("Yakıt dolmuştur");
                            Console.WriteLine("Yakıt tankında {0} litre dizel yakıt kaldı", dizelTank);
                        }
                    }
                }
                else if (akaryakitSatisTipi == 'B' || akaryakitSatisTipi == 'b')
                {
                    if (benzinTank == 0)
                    {
                        Console.WriteLine("Yakıt tankında benzin yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık benzin satacaksınız: ");
                        satisMiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzinTank < satisMiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre benzin vardır! İşlem yapılamadı", benzinTank);
                            goto MENU;
                        }
                        else if (satisMiktari <= benzinTank)
                        {
                            benzinTank = benzinTank - satisMiktari;
                            Console.WriteLine("Yakıt dolmuştur");
                            Console.WriteLine("Yakıt tankında {0} litre benzin kaldı", benzinTank);
                        }
                    }
                }
                else if (akaryakitSatisTipi == 'L' || akaryakitSatisTipi == 'l')
                {
                    if (lpgTank == 0)
                    {
                        Console.WriteLine("Yakıt tankında LPG yakıt kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık LPG yakıt satacaksınız: ");
                        satisMiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgTank < satisMiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre LPG yakıt vardır! İşlem yapılamadı", lpgTank);
                            goto MENU;
                        }
                        else if (satisMiktari <= lpgTank)
                        {
                            lpgTank = lpgTank - satisMiktari;
                            Console.WriteLine("Yakıt dolmuştur");
                            Console.WriteLine("Yakıt tankında {0} litre LPG yakıt kaldı", lpgTank);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı seçim [D,B,L]: ");
                    goto AKARYAKITSATISI;
                }
                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menü 2: Programı Kapat]: ");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız (1,2)");
                    goto ALTMENU;
                }
            }
            else if (anaMenuSecim == '4')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz 4");
                Console.WriteLine("---Depo Durumu---");
                Console.WriteLine("Dizel yakıt tankı %{0} doludur", (dizelTank / 10));
                Console.WriteLine("Benzin tankı %{0} doludur", (benzinTank / 10));
                Console.WriteLine("LPG yakıt tankı %{0} doludur", (lpgTank / 10));
                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menü 2: Programı Kapat]: ");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız (1,2)");
                    goto ALTMENU;
                }
            }
            else if (anaMenuSecim == '5')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz 5");
                Console.WriteLine("---Toplam Satış Durumu---");
                Console.WriteLine("Satılan toplam dizel yakıt: {0}", 1000 - dizelTank);
                Console.WriteLine("Dizel yakıt tutarı: {0}", (1000 - dizelTank) * dizel);
                Console.WriteLine("Satılan toplam benzin: {0}", 1000 - benzinTank);
                Console.WriteLine("Benzin tutarı: {0}", (1000 - benzinTank) * benzin);
                Console.WriteLine("Satılan toplam LPG yakıt: {0}", 1000 - lpgTank);
                Console.WriteLine("LPG yakıt tutarı: {0}", (1000 - lpgTank) * lpg);
                Console.WriteLine("_____________________-_____");
                Console.WriteLine("Toplam tutar: {0}", ((1000 - dizelTank) * dizel) + ((1000 - benzinTank) * benzin) + ((1000 - lpgTank) * lpg));
                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menü 2: Programı Kapat]: ");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız (1,2)");
                    goto ALTMENU;
                }
            }
            else if (anaMenuSecim == '6')
            {
                Environment.Exit(0);
            }


        }
    }
}
