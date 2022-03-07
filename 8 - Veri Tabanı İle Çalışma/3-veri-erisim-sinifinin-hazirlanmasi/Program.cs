using MySql.Data.MySqlClient;

var productDal = new ProductManager(new MySqlProductDal());

var products = productDal.GetAllProducts();

foreach (var prd in products) {
    System.Console.WriteLine($"{prd.Name}");
}

public class ProductManager : IProductDal
{
    IProductDal _productDal;
    public ProductManager(IProductDal productDal) {
        _productDal = productDal;
    }
    public void Create(Product p)
    {
        throw new NotImplementedException();
    }

    public void Delete(int productId)
    {
        throw new NotImplementedException();
    }

    public List<Product> Find(string productName)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllProducts()
    {
        return _productDal.GetAllProducts();
    }

    public Product GetProductById(int id)
    {
        throw new NotImplementedException();
    }
 
    public void Update(Product p)
    {
        throw new NotImplementedException();
    }
}
class MySqlProductDal : IProductDal {
    private MySqlConnection GetMySqlConnection() {
        string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=12345;";
        return new MySqlConnection(connectionString);
    }

    public void Create(Product p) { throw new NotImplementedException(); }
    public void Delete(int productId) { throw new NotImplementedException(); }
    public List<Product> GetAllProducts() {
        List<Product> products = null;
        using (var connection = GetMySqlConnection()) { 
            try {
                connection.Open();
                string sql = "select * from products";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                products = new List<Product>();

                while(reader.Read()) {
                    products.Add(
                        new Product{
                            ProductId = int.Parse(reader["id"].ToString()),
                            Name = reader["product_name"].ToString(),
                            Price = double.Parse(reader["list_price"].ToString())
                    });
                }
                reader.Close();

            } catch (Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return products;
    }
    public Product GetProductById(int id) { throw new NotImplementedException(); }
    public void Update(Product p) { throw new NotImplementedException(); }

    public List<Product> Find(string productName) { throw new NotImplementedException(); }
}