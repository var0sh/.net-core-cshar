bool cikis = true;

do
{
    System.Console.Write("ürün adedi: ");
    int adet = int.Parse(Console.ReadLine());
    Product[] products = new Product[adet];

    int i = 0;
    // Product prd;

    while (i < adet) {

        Product prd = new Product();

        System.Console.Write($"{i + 1}. ürün adı: ");
        prd.Name = Console.ReadLine();
        System.Console.Write($"{i + 1}. ürün fiyatı: ");
        prd.Price = int.Parse(Console.ReadLine());
        System.Console.Write($"{i + 1}. ürün açıklaması: ");
        prd.Desc = Console.ReadLine();

        products[i] = prd;

        i++;
    }

    System.Console.WriteLine("**************");
    
    for (int a = 0; a < products.Length; a++) 
        System.Console.WriteLine($"{a + 1}. ürün:\nname: {products[a].Name} | price: {products[a].Price} | açıklama: {products[a].Desc}");
    
    

    System.Console.Write("Çıkış yapılsın mı? (e/h)");
    string tercih = Console.ReadLine();

    if (tercih == "e")
        cikis = false;

} while (cikis);

class Product {
    public string? Name { get; set; }
    public int? Price { get; set; }
    public string? Desc { get; set; }
}