// kullanıcıdan isim yaş eğitim bilgilerini isteyip ehliyet alabilme durumunu kontrol ediniz.
    // yaş en az 18, eğitim durumu en az lise

// System.Console.Write("isim: ");
// string name = Console.ReadLine();
// System.Console.Write("yaş: ");
// int age = int.Parse(Console.ReadLine());
// System.Console.Write("eğitim durumu ilk okul (i), orta okul (o), lise (l), üni (ü), mezun (m): ");
// string state = Console.ReadLine();

// if (age >= 18) {
//     if (state != "i" && state != "o") {
//         System.Console.WriteLine($"sayın {name} ehliyet alabilirsiniz");
//     } else {
//         System.Console.WriteLine($"sayın {name} yaşınız tutuyor fakat eğitim durumunuz yeterli değil");
//     }
// } else {
//     System.Console.WriteLine($"sayın {name} yaşınız yeterli değil");
// }



// girilen 3 sayıdan en büyüğünü bulunuz

// System.Console.Write("sayı 1: ");
// int a = int.Parse(Console.ReadLine());
// System.Console.Write("sayı 2: ");
// int b = int.Parse(Console.ReadLine());
// System.Console.Write("sayı 3: ");
// int c = int.Parse(Console.ReadLine());

// if (a > b && a > c) {
//     System.Console.WriteLine($"en büyük sayı {a}");
// } else if (b > a && b > c) {
//     System.Console.WriteLine($"en büyük sayı {b}");
// } else if (c > a && c > b) {
//     System.Console.WriteLine($"en büyük sayı {c}");
// }


// bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ort göre not aralığına karşılık gelen not bilgisini yazdırınız
    // 0-24 => 0
    // 25-44 => 1
    // 45-54 => 2
    // 55-69 => 3
    // 70-84 => 4
    // 85-100 => 5

// System.Console.Write("birinci yazılı notu: ");
// int yazili1 = int.Parse(Console.ReadLine());
// System.Console.Write("ikinci yazılı notu: ");
// int yazili2 = int.Parse(Console.ReadLine());
// System.Console.Write("sözlü notu: ");
// int sozlu = int.Parse(Console.ReadLine());

// int ort = (yazili1 + yazili2 + sozlu) / 3;

// if (ort > 0 && ort < 24) {
//     System.Console.WriteLine("notunuz 0");
// } else if(ort >= 25 && ort <= 44) {
//     System.Console.WriteLine("notunuz 1");
// } else if(ort >= 45 && ort <= 54) {
//     System.Console.WriteLine("notunuz 2");
// } else if(ort >=55 && ort <= 69) {
//     System.Console.WriteLine("notunuz 3");
// } else if(ort >= 70 && ort <= 84) {
//     System.Console.WriteLine("notunuz 4");
// } else if(ort >= 85 && ort <= 100) {
//     System.Console.WriteLine("notunuz 5");
// }


// trafiğe çıkış tarihi alınan bir aracın servis zamanını aşağıdaki bilgilere göre hesaplayınız
    // 1. bakım => 1. yıl
    // 2. bakım => 2. yıl
    // 3. bakım => 3. yıl
    // ** süre hesabını alınan gün, ay, yıl bilgisine göre gün bazlı hesaplayınız

System.Console.Write("aracınızın trafiğe çıktığı yıl: ");
int year = int.Parse(Console.ReadLine());
System.Console.Write("aracınızın trafiğe çıktığı ay: ");
int month = int.Parse(Console.ReadLine());
System.Console.Write("aracınızın trafiğe çıktığı gün: ");
int day = int.Parse(Console.ReadLine());

var cikis = new DateTime(year, month, day);
var now = DateTime.Now;

var trafikte = now - cikis;

if (trafikte < TimeSpan.Parse("365")) {
    System.Console.WriteLine("aracınızın ilk bakımı daha gelmemiş");
} else if(trafikte > TimeSpan.Parse("364") && trafikte < TimeSpan.Parse("730")) {
    System.Console.WriteLine("aracınızın ilk bakım zamanı gelmiş");
} else if(trafikte > TimeSpan.Parse("730") && trafikte < TimeSpan.Parse("995")) {
    System.Console.WriteLine("aracınızın ikinici bakım zamanı gelmiş");
}