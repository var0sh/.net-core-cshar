// **Exception

// **Unhandled exception. System.FormatException
// **Unhandled exception. System.DivideByZeroException
// **Unhandled exception. System.IndexOutOfRangeException
// **Unhandled exception. System.NullReferenceException

System.Console.Write("sayı 1: ");
var sayi1 = int.Parse(Console.ReadLine());
System.Console.Write("sayı 2: ");
var sayi2 = int.Parse(Console.ReadLine());
int[] sayilar = new int[2];
// sayilar[2] = 10;

var sonuc = sayi1 / sayi2;

Product p = null;
System.Console.WriteLine(p.Name);

class Product {
    public string Name { get; set; }
}