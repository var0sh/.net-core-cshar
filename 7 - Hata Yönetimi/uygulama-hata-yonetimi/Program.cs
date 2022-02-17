// ** "1", "2", "5a", "10b", "abc", "10", "50"
// ** liste içindeki sayısal değerleri bulunuz

// List<string> liste = new List<string> {
//     "1", "2", "5a", "10b", "abc", "10", "50"
// };

// foreach(var item in liste) {
//     try {
//         int a = int.Parse(item);
//         System.Console.WriteLine(a);
//     } catch (Exception err) {
//         System.Console.WriteLine($"{item} intager değer değil");
//     }
// };


// ** kullanıcı 'q' değerini girmedikçe aldığınız her değerin sayısal olup olmadığını kontrol edin aksi halde hata mesajı verin


// while (true) {
//     System.Console.Write("sayı: ");
//     var input = Console.ReadLine();

//     if (input == "q")
//         break;

//     try {
//         int sayi = int.Parse(input);
//     } catch (System.Exception err) {
//         System.Console.WriteLine(err.Message);
//     }
// }   


// ** girilen parola içinde türkçe karakter araması yapınız

// System.Console.WriteLine("parola: ");
// string parola = Console.ReadLine();

// try {
//     CheckPassword(parola);
// } catch (System.Exception err) {
//     System.Console.WriteLine(err.Message);
// }

// static void CheckPassword(string parola) {
//     string turkce_karakterler = "ğ, Ğ, ç, Ç, ş, Ş, ü, Ü, ö, Ö, ı, İ";

//     foreach (var charr in parola) {
//         if (turkce_karakterler.IndexOf(charr) > -1) {
//             throw new Exception("parola türkçe karakter içermez");
//         }
//     }
//     System.Console.WriteLine("geçerli parola");

// }