System.Console.Write("sayı: ");
int sayi = int.Parse(Console.ReadLine());

bool asalmi = true;

if (sayi == 1)
    asalmi = false;

for (int i = 2; i < sayi; i++) {

    if (sayi % i == 0) {
        asalmi = false;
        break;
    }

}

if (asalmi)
    System.Console.WriteLine($"{sayi} asal");
else
    System.Console.WriteLine($"{sayi} asal değil");