using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uygulama_interface_repository_pattern_1.DataAccess.Abstract;
using uygulama_interface_repository_pattern_1.Entity;

namespace uygulama_interface_repository_pattern_1.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category[] GetCategories()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}