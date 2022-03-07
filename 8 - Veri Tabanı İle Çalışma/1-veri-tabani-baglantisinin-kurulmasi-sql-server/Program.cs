using MySql.Data.MySqlClient;

GetMySqlConnection();

static void GetMySqlConnection() {
    string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=12345;";

    using (var connection = new MySqlConnection(connectionString)) { 
        try {
            connection.Open();
            System.Console.WriteLine("bağlantı sağlandı");
        } catch (Exception err) {
            System.Console.WriteLine(err.Message);
        } finally {
            connection.Close();
        }
    }
}
