// Generic List
List<int> sayilar = new List<int>();

sayilar.Add(10);
sayilar.Add(20);
sayilar.Add(30);

List<string> isimler = new List<string>();

isimler.Add("furkan");
isimler.Add("ayşe");
isimler.Add("taha");

List<Product> products1 = new List<Product>();
IList<Product> products2 = new List<Product> {
    new Product("prd 4"),
    new Product("prd 5"),
    new Product("prd 6"),
};

products1.Add(new Product("prd 1"));
products1.Add(new Product("prd 2"));
products1.Add(new Product("prd 3"));

products1.AddRange(products2);

sayilar.Insert(3, 40);
products1.InsertRange(1, products2);

sayilar.Remove(10);
sayilar.RemoveAt(0);

// products1.ForEach(p => System.Console.WriteLine(p.Name));
sayilar.ForEach(p => System.Console.WriteLine(p));


class Product {
    public Product(string name) {
        this.Name = name;
    }
    public string Name { get; set; }
}