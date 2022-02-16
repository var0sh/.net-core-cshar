using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uygulama_interface_repository_pattern_1.Entity;

namespace uygulama_interface_repository_pattern_1.DataAccess.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Update(Product entity);
        void Create(Product entity);
        void Delete(int id);
        Product[] GetProductsByCategory(int id);

    }
}