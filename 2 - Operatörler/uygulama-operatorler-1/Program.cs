// int x = 2, y = 5, z = 10;

// kullanıcıdan alınan iki sayının çarpımı ile x y z nin toplamı arasındaki fark kaçtır
// System.Console.Write("1. sayı: ");
// int number1 = int.Parse(Console.ReadLine());
// System.Console.Write("2. sayı: ");
// int number2 = int.Parse(Console.ReadLine());

// int carpim = number1 * number2;
// int toplam = x + y + z;
// int fark = Math.Abs(carpim - toplam);

// System.Console.WriteLine($"fark: {fark}");


// kullanıcıdan alınan bir sayının tek çift kontrolünü yapınız
// System.Console.Write("sayı: ");
// int sayi = int.Parse(Console.ReadLine());
// int kalan = sayi % 2;

// if (kalan == 0)
// {
//     System.Console.WriteLine("girilen sayı çift");
// }else {
//     System.Console.WriteLine("girilen sayı tek");
// } 


// x y z toplamının mod 3ü kaçtır
// int top = x + y + z;
// int result = top % 3;
// System.Console.WriteLine(result);


// y nin x inci kuvveti
// System.Console.WriteLine(Math.Pow(y, x));

// faktöriyel bulma
// System.Console.Write("sayı: ");
// int n = int.Parse(Console.ReadLine());

// int faktoriyel = 1;
// for (int sayac = 0; sayac < n;) {
//     sayac += 1;
//     faktoriyel = faktoriyel * sayac;
//     System.Console.WriteLine(faktoriyel);
// }


// top, çarpım, ortlama bulma

// System.Console.Write("sayı 1: ");
// int sayi1 = int.Parse(Console.ReadLine());
// System.Console.Write("sayı 2: ");
// int sayi2 = int.Parse(Console.ReadLine());

// int top = sayi1 + sayi2, carpim = sayi1 * sayi2, ort = top / 2;

// System.Console.WriteLine($"top: {top}, çarpım: {carpim}, ortalama: {ort}");


// girilen sayının çarpanlarını bulma
// System.Console.Write("sayi: ");
// int a = int.Parse(Console.ReadLine());

// for (int i = 1; i <= a; i++) {
//     if (a % i == 0) {
//         System.Console.WriteLine(i);
//     }
// }


// 1-100 arasında aklımızdan tuttuğumuz sayıya bulma
// System.Console.Write("tuttuğun sayı: ");
// int tutulan = int.Parse(Console.ReadLine());


// System.Console.WriteLine("eğer tuttuğunuz sayı tahmin ettiğimizden büyükse (h), küçükse (e), eşitse (b) giriniz");
// string girdi = Console.ReadLine();

// while (girdi != "b") {
    
//     int min = 0, max = 100;
//     int tahmin = (max - min) / 2 + min;

//     System.Console.WriteLine($"tahmin ettiğimiz sayı: {tahmin}");
    
//     if (girdi == "e") {
//         max = tahmin;
//     }else if(girdi == "h") {
//         min = tahmin;
//     }else if(girdi == "b") {
//         System.Console.WriteLine($"girdiğiniz sayı {tahmin}");
//     }   
// }