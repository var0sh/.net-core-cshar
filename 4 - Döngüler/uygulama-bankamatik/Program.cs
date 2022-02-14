string secim = "";
double bakiye = 0, ekHesap = 1000, ekHesapLimiti = 1000;

do
{
    
    System.Console.WriteLine("1 - Bakiye Görüntüleme\n2 - Para Yatırma İşlemleri\n3 - Para Çekme\n4 - Çıkış");
    secim = Console.ReadLine();

    switch (secim) {
        case "1":
            System.Console.WriteLine($"Bakiye: {bakiye} TL");
            System.Console.WriteLine($"Ek Hesap Bakiye: {ekHesap} TL");
            break;
        case "2":
            System.Console.Write("Yatırmak istediğiniz miktar: ");
            double yatirilan = double.Parse(Console.ReadLine());

            if (ekHesap < ekHesapLimiti) {
                System.Console.WriteLine("Ek hesaba yatırılsın mı? (e/h)");
                string tercih1 = Console.ReadLine();

                if (tercih1 == "e") {
                    double eksik = ekHesapLimiti - ekHesap;

                    double bakiyeyeAktarilacak = yatirilan - eksik;
                    yatirilan -= eksik;
                    ekHesap += eksik;
                    bakiye += bakiyeyeAktarilacak;

                } else {
                    bakiye += yatirilan;
                }

            } else {
                bakiye += yatirilan;
            }

            break;
        case "3":
            System.Console.WriteLine("Çekmek istediğiniz miktar: ");
            double cekilen = double.Parse(Console.ReadLine());

            if (cekilen > bakiye) {

                double toplam = bakiye + ekHesap;

                if (toplam > cekilen) {
                    System.Console.Write("Ek hesap kullanılsın mı? (e/h)");
                    string tercih = Console.ReadLine();

                    if (tercih == "e") {

                        ekHesap -= (cekilen - bakiye);
                        bakiye = 0;

                        System.Console.WriteLine("Paranızı alabilirsiniz.");
                    } else {
                        System.Console.WriteLine("Bakiyeniz yetersiz.");
                    }

                }
            } else {
                bakiye -= cekilen;
                System.Console.WriteLine("Paranızı alabilirsiniz.");
            }

            break;
        case "4":
            System.Console.Write("Çıkış");
            break;
    }
} while (secim != "4");