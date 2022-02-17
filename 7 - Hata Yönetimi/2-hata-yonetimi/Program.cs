try {
    System.Console.Write("a: ");
    int a = int.Parse(Console.ReadLine());
    
    System.Console.Write("b: ");
    int b = int.Parse(Console.ReadLine());
    
    var sonuc = a / b;
    
    System.Console.WriteLine($"{a} / {b} = {sonuc}");
} 
// catch (System.DivideByZeroException error) {
//     System.Console.WriteLine("b 0 olamaz");
//     System.Console.WriteLine(error.Message);
// } 
// catch (FormatException error) {
//     System.Console.WriteLine("sayısal bilgi girmelisiniz");
//     System.Console.WriteLine(error.Message);
// } 
catch (Exception err) {
    System.Console.WriteLine("Bir hata oluştu.");
    System.Console.WriteLine(err.Message);
}
finally {
    System.Console.WriteLine("finally bloğu çalıştı");
}