using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uygulama_interface_repository_pattern_1.Entity;

namespace uygulama_interface_repository_pattern_1.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        void Update(Category entity);
        void Create(Category entity);
        void Delete(int id);
    }
}