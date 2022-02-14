System.Console.Write("ürün adedi: ");
int adet = int.Parse(Console.ReadLine());

string[] urunler = new string[adet];

int i = 0;
int sayac = 1;
int sayac2 = 1;

do
{
    System.Console.Write($"{sayac}. ürün adı: ");
    urunler[i] = Console.ReadLine();
    i++;
    sayac++;

} while (i < urunler.Length);

for (int a = 0; a < urunler.Length; a++) {
    System.Console.WriteLine($"listelenen ürünler - {sayac2}. ürün: {urunler[a]}");
    sayac2++;
}