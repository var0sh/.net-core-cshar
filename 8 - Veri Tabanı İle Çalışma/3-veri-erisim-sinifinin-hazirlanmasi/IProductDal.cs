public interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        List<Product> Find(string productName);
        void Create(Product p);
        void Update(Product p);
        void Delete(int productId);
    }