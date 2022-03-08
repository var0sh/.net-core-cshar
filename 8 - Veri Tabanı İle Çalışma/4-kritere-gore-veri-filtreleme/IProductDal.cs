public interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        List<Product> Find(string productName);
        int Count();
        int Create(Product p);
        void Update(Product p);
        void Delete(int productId);
    }