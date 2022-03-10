using MySql.Data.MySqlClient;

var productDal = new ProductManager(new MySqlProductDal());

productDal.Delete(101); 

public class ProductManager : IProductDal {
    IProductDal _productDal;
    public ProductManager(IProductDal productDal) {
        _productDal = productDal;
    }
    public int Count() {
        return _productDal.Count();
    }
    public int Create(Product p) {
        return _productDal.Create(p);
    }
    public int Delete(int productId) {
        return _productDal.Delete(productId);
    }
    public List<Product> Find(string productName) {
        return _productDal.Find(productName);
    }
    public List<Product> GetAllProducts() {
        return _productDal.GetAllProducts();
    }
    public Product GetProductById(int id) {
        return _productDal.GetProductById(id);
    }
    public int Update(Product p) {
        return _productDal.Update(p);
    }
}
class MySqlProductDal : IProductDal { 
    private MySqlConnection GetMySqlConnection() {
        string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=12345;";
        return new MySqlConnection(connectionString);
    }
    public int Create(Product p) {
        int result = 0;
        using (var connection = GetMySqlConnection()) {
            try {
                connection.Open();

                string sql = "insert into products (product_name, list_price, discontinued) VALUES (@name, @price, @discontinued)";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.Add("@name", MySqlDbType.Int32).Value = p.Name;
                command.Parameters.Add("@price", MySqlDbType.Double).Value = p.Price;
                command.Parameters.Add("@discontinued", MySqlDbType.Int32).Value = 1;

                result = command.ExecuteNonQuery();
                
                System.Console.WriteLine($"{result} adet kayıt eklendi.");

            } catch (System.Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return result;
    }
    public int Delete(int productId) {
        int result = 0;
        using (var connection = GetMySqlConnection()) {
            try {
                connection.Open();

                string sql = "DELETE FROM products WHERE id = @prdId;";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.Add("@prdId", MySqlDbType.Int32).Value = productId;

                result = command.ExecuteNonQuery();
                
                System.Console.WriteLine($"{result} adet kayıt silindi.");

            } catch (System.Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return result;
    }
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
    public Product GetProductById(int id) {
        Product product = null;
        using (var connection = GetMySqlConnection()) { 
            try {
                connection.Open();
                string sql = "select * from products where id = @productId";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@productId", MySqlDbType.Int32).Value = id;
                MySqlDataReader reader = command.ExecuteReader();
                
                reader.Read();

                if (reader.HasRows){
                    product = new Product{
                        ProductId = int.Parse(reader["id"].ToString()),
                        Name = reader["product_name"].ToString(),
                        Price = double.Parse(reader["list_price"].ToString())
                    };
                }
                reader.Close();

            } catch (Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return product;
    }
    public int Update(Product p) {
        int result = 0;
        using (var connection = GetMySqlConnection()) {
            try {
                connection.Open();

                string sql = "UPDATE products SET product_name = @prdName, list_price = @price WHERE id=@prdId";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.Add("@prdName", MySqlDbType.String).Value = p.Name;
                command.Parameters.Add("@price", MySqlDbType.Double).Value = p.Price;
                command.Parameters.Add("@prdId", MySqlDbType.Int32).Value = 101;

                result = command.ExecuteNonQuery();
                
                System.Console.WriteLine($"{result} adet kayıt güncellendi.");

            } catch (System.Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return result;
    }
    public List<Product> Find(string productName) {
        List<Product> products = null;
        using (var connection = GetMySqlConnection()) { 
            try {
                connection.Open();
                string sql = "SELECT * from products where product_name LIKE @productName";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@productName", MySqlDbType.String).Value = "%" + productName + "%";
                MySqlDataReader reader = command.ExecuteReader();
                
                products = new List<Product>();

                while (reader.Read()) {
                    products.Add(
                        new Product{
                            ProductId = int.Parse(reader["id"].ToString()),
                            Name = reader["product_name"].ToString(),
                            Price = double.Parse(reader["list_price"].ToString())
                        });
                }

            } catch (Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return products;
    }
    public int Count() {
        int count = 0;
        using (var connection = GetMySqlConnection()) { 
            try {
                connection.Open();
                string sql = "select count(*) from products";

                MySqlCommand command = new MySqlCommand(sql, connection);

                object result = command.ExecuteScalar();

                if (result != null) {
                    count = Convert.ToInt32(result);
                }

            } catch (Exception err) {
                System.Console.WriteLine(err.Message);
            } finally {
                connection.Close();
            }
        }
        return count;
    }
}