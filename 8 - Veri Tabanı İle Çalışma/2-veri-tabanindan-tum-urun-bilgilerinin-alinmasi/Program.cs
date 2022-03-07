using MySql.Data.MySqlClient;

GetAllProducts();
var products = GetAllProducts();

foreach(var prd in products) {
    System.Console.WriteLine($"id: {prd.ProductId} | name: {prd.Name} | price: {prd.Price}");
}

static List<Product> GetAllProducts () {
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
                    System.Console.WriteLine($"name: {reader[3]} | price: {reader[6]}");
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
static MySqlConnection GetMySqlConnection() {
    string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=12345;";
    return new MySqlConnection(connectionString);
}