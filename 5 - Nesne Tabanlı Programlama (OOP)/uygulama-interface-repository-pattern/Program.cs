using uygulama_interface_repository_pattern_1.DataAccess.Abstract;
using uygulama_interface_repository_pattern_1.DataAccess.Concrete;
using uygulama_interface_repository_pattern_1.Entity;

// var product = new EfProductDal();
// var product = new MySQLProductDal();
// product.Create(new Product());

var product = new ProductManager(new EfProductDal());
var product1 = new ProductManager(new MySQLProductDal());
product.Create(new Product());
product1.Create(new Product());

class ProductManager : IProductRepository {

    public IProductRepository _repository { get; set; }

    public ProductManager(IProductRepository repository)
    {
        _repository = repository;
    }

    public void Create(Product entity)
    {
        _repository.Create(entity);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Product[] GetPopularProducts()
    {
        throw new NotImplementedException();
    }

    public Product[] GetProductsByCategory(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}