using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uygulama_interface_repository_pattern_1.DataAccess.Abstract;
using uygulama_interface_repository_pattern_1.Entity;

namespace uygulama_interface_repository_pattern_1.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
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
}