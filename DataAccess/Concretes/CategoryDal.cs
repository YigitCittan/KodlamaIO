using DataAccess.Abstracts;
using Entity.Concretes;
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
                new Category() { Id = 1, Name= "Yazılım"},
                new Category() { Id = 2, Name= "Network"},
                new Category() { Id = 3, Name= "SiberGüvenlik"}

            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(_categories.SingleOrDefault(c => c.Id == category.Id));
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GettAll()
        {
            return _categories;
        }   

        public void Update(Category category)
        {
            Category categoryUpdate = _categories.SingleOrDefault(c =>c.Id == category.Id);
            categoryUpdate.Name = category.Name;
        }
    }
}
