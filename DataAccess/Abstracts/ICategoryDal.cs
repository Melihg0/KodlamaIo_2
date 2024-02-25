using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category UptatedCategory);
        Category GetCategory(int categoryId);
        List<Category> GetAll();
        
    }
}
