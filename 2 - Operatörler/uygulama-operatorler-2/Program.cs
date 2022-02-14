// girilen iki sayıdan hangisi büyüktür
// System.Console.Write("sayı 1: ");
// int sayi1 = int.Parse(Console.ReadLine());
// System.Console.Write("sayı 2: ");
// int sayi2 = int.Parse(Console.ReadLine());

// string result = sayi1 > sayi2 ? $"{sayi1} {sayi2}den büyüktür" : $"{sayi2} {sayi1} den büyüktür";

// System.Console.WriteLine(result);

// *********************************

// paralo ve email isteyip doğruluğunu kontrol et
// string pass = "12345", email = "email";

// System.Console.Write("email: ");
// string girilenEmail = Console.ReadLine();
// System.Console.Write("password: ");
// string girilenPass = Console.ReadLine();

// string result = girilenEmail == email ? 
//     girilenPass == pass ? "email ve password doğru" : "email doğru password yanlış" : 
//     girilenPass == pass ? "email yanlış password doğru" : "email ve password yanlış";

// System.Console.WriteLine(result);

// *********************************

// girilen sayının pozitif çift sayı olup olmadığını kontrol et
// System.Console.Write("sayı: ");
// int sayi = int.Parse(Console.ReadLine());

// string result = sayi > 0 ? 
//     sayi % 2 == 0 ? "girilen sayı çift ve pozitif" : "girilen sayı tek ve pozitif":
//     sayi % 2 == 0 ? "girilen sayı çift ve negatif" : "girilen sayı tek ve negatif";

// System.Console.WriteLine(result);

// *********************************

// girilen 3 sayıyı büyüklük olarak karşılaştırınız
// System.Console.Write("sayi 1: ");
// int sayi1 = int.Parse(Console.ReadLine());
// System.Console.Write("sayi 2: ");
// int sayi2 = int.Parse(Console.ReadLine());
// System.Console.Write("sayi 3: ");
// int sayi3 = int.Parse(Console.ReadLine());

// string result1 = sayi1 > sayi2 ? $"{sayi1} > {sayi2}" : $"{sayi2} > {sayi1}";
// string result2 = sayi2 > sayi3 ? $"{sayi2} > {sayi3}" : $"{sayi3} > {sayi2}";
// string result3 = sayi1 > sayi3 ? $"{sayi1} > {sayi3}" : $"{sayi3} > {sayi1}";

// System.Console.WriteLine($"karşılaştırma sonuçları: {result1}, {result2}, {result3}");

// *********************************

// kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ort hesapla. geçtiyse geçti kaldıysa kaldı yazdır
    // ort 50 olsa final 50 ve üzeri olmalıdır
    // final 70 ve üzeriyse ort gerek yok

// System.Console.Write("vize 1: ");
// int vize1 = int.Parse(Console.ReadLine());
// System.Console.Write("vize 2: ");
// double vize2 = int.Parse(Console.ReadLine());
// System.Console.Write("final: ");
// double final = int.Parse(Console.ReadLine());

// double ort = (((vize1 + vize2) / 2) * (0.6)) + ((final) * (0.4));

// string result = ((ort >= 50) && (final >= 50)) || (final >= 70) ? "geçti" : "kaldı";

// System.Console.WriteLine($"ort: {ort} {result}");

// *********************************

// kişinin ad kilo ve boylarını alıp kilo indeksini hesapla
    // formul: kilo / boy * boy
    // 0-18.4 => zayıf
    // 18.5-24.9 => normal
    // 25.0-29.9 => fazla kilolu
    // 30.0-34.9 => şişman(obez)

// System.Console.Write("isim: ");
// string name = Console.ReadLine();
// System.Console.Write("boy: ");
// float boy = float.Parse(Console.ReadLine());
// System.Console.Write("kilo: ");
// float kilo = float.Parse(Console.ReadLine());

// var index = (kilo / (boy * boy));

// string result = index > 0 ?
//     index <= 18.4 ? "zayıf":
//     index <= 24.9 ? "normal":
//     index <= 29.9 ? "kilolu" : "obez" : "hata!!";

// System.Console.WriteLine($"sayın {name} boy kilo indeksiniz: {result}, sayısal: {index}");