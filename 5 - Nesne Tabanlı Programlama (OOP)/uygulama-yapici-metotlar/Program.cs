var p1 = new Product();
var p2 = new Product(123);
var p3 = new Product(new Random().Next(111, 3333), "phone", 1000, true);

var c1 = new Comment {
    CommentId = 1,
    Text = "güzel telefon"
};

p1.Comments[0] = c1;
p2.Comments[0] = c1;
p3.Comments[0] = c1;

System.Console.WriteLine($"id: {p1.ProductId} | name: {p1.Name} | fiyat: {p1.Price} | onay: {p1.IsApproved} | comment-text: {p1.Comments[0].Text}");
System.Console.WriteLine("**********");
System.Console.WriteLine($"id: {p2.ProductId} | name: {p2.Name} | fiyat: {p2.Price} | onay: {p2.IsApproved} | comment-text: {p2.Comments[0].Text}");
System.Console.WriteLine("**********");
System.Console.WriteLine($"id: {p3.ProductId} | name: {p3.Name} | fiyat: {p3.Price} | onay: {p3.IsApproved} | comment-text: {p3.Comments[0].Text}");

class Comment {
    public int CommentId { get; set; }
    public string Text { get; set; }
}
class Product {

    public Product () {
        this.Comments = new Comment[3];
        this.ProductId = new Random().Next(11111, 99999);
    }
    public Product (int productId): this() {
        this.ProductId = productId;
    }
    public Product (int productId, string name, double price, bool isApproved): this(productId) {
        this.Name = name;
        this.Price = price;
        this.IsApproved = isApproved;
    }

    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsApproved { get; set; }
    public Comment[] Comments { get; set; }
}