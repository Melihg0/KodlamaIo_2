using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category() {CategoryId=1,CategoryName="Yazılım Geliştirme"},
                new Category() {CategoryId=2,CategoryName="Matematik"}
            };

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            Category categoryToDelete = _categories.SingleOrDefault(p => p.CategoryId ==categoryId );
            _categories.Remove(categoryToDelete);
        }

        public void Update(Category UpdatedCategory)
        {
            Category category = _categories.SingleOrDefault(p => p.CategoryId == UpdatedCategory.CategoryId);
            category.CategoryName = UpdatedCategory.CategoryName;
        }

        Category ICategoryDal.GetCategory(int categoryId)
        {
            Category category = _categories.SingleOrDefault(p => p.CategoryId == categoryId);
            return category;
        }

         List<Category> ICategoryDal.GetAll()
        {
            return _categories;
        }
    }
}
