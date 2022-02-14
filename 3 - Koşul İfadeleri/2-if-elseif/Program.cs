// System.Console.Write("x: ");
// int x = int.Parse(Console.ReadLine());
// System.Console.Write("y: ");
// int y = int.Parse(Console.ReadLine());

// if(x > y) {
//     System.Console.WriteLine("x > y");
// } else if(x == y) {
//     System.Console.WriteLine("x = y");
// } else {
//     System.Console.WriteLine("x < y");
// }

Console.Write("sayı: ");
int sayi = int.Parse(Console.ReadLine());

if(sayi > 0) {
    System.Console.WriteLine("sayı pozitif");
} else if(sayi == 0) {
    System.Console.WriteLine("sayı sıfır");
} else {
    System.Console.WriteLine("sayı negatif");
}