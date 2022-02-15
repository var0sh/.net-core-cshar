// var products = ProductManager.GetProducts();
// var product = ProductManager.GetProductById(1);
var product = ProductManager.GetProductByName("phone");
System.Console.WriteLine("id: " + product.Id + " name: " + product.Name);

// foreach (var item in products) {
//     System.Console.WriteLine($"name: {item.Name} | price: {item.Price} ");
// }

static class ProductManager {

    static ProductManager() {
        
        Products = new Product[5];

        Products[0] = new Product {
            Id = 1,
            Name = "phone 1",
            Price = 2000,
            IsApproved = false
        };
        Products[1] = new Product {
            Id = 2,
            Name = "phone 2",
            Price = 3000,
            IsApproved = false
        };
        Products[2] = new Product {
            Id = 3,
            Name = "phone 3",
            Price = 4000,
            IsApproved = true
        };
        Products[3] = new Product {
            Id = 4,
            Name = "phone 4",
            Price = 5000,
            IsApproved = true
        };
        Products[4] = new Product {
            Id = 5,
            Name = "phone 5",
            Price = 6000,
            IsApproved = true
        };

    }
    public static Product[] GetProducts() {
        return Products;
    }
    public static Product GetProductById(int id) {
        Product product = null; // new Product(); demiş gibi oluyoruz yoksa hata verir

        foreach (var item in Products) {
            if (item.Id == id)
                product = item;
        }

        return product;
    } 
    public static Product GetProductByName(string name) {
        Product product = null;

        foreach (var item in Products) {
            if (item.Name.Contains(name.ToLower())) {
                product = item;
                break;
            }
        }

        return product;
    }

    static Product[] Products;
}

class Product {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsApproved { get; set; }
}