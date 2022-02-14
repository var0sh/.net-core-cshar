// kullanıcıdan başlangıç bitiş ve artış miktarı alarak aralıktaki tüm sayıları ekrana yazdırınız

// System.Console.Write("başlangıç: ");
// int start = int.Parse(Console.ReadLine());
// System.Console.Write("bitiş: ");
// int finish = int.Parse(Console.ReadLine());
// System.Console.Write("artış: ");
// int artis = int.Parse(Console.ReadLine());

// for (int i = start; i <= finish; i += artis) {
//     System.Console.WriteLine(i);
// }


int[] numbers = {1, 3, 5, 6, 7, 23, 67, 90, 93, 100};
// sayılar dizisindeki hangi sayılar 3ün aktıdır

// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] % 3 == 0) {
//         System.Console.WriteLine(numbers[i]);
//     }
// }


// sayılar dizisindeki sayıların toplamı kaçtır

// int top = 0;

// for (int i = 0; i < numbers.Length; i++) {
//     top += numbers[i]; 
// }

// System.Console.WriteLine(top);   



// sayılar dizisindeki tek sayıların karesini ekrana yazdırınız

// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] % 2 == 1) {
//         System.Console.WriteLine(Math.Pow(numbers[i], 2));
//     }
// }



string[] cars = {"opel", "mazda", "toyota", "bmw", "mercedes"};
// arabalar dizisindeki en az 5 karakterli elemanları yazdırınız

// for (int i = 0; i < cars.Length; i++) {
//     if (cars[i].Length >= 5) {
//         System.Console.WriteLine(cars[i]);
//     }
// }