using Entities.FakeLocalStorage;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDal
    {
        public List<Category> GetAll()
        {
            return LocalStorage.GetAllCategory();
        }

        public Category GetById(int id)
        {
            Category result = new Category();

            foreach (var category in LocalStorage.GetAllCategory())
            {
                if (category.Id == id)
                {
                    result = category;
                    break;
                }

            }

            return result;
        }

        public void Add(Category category)
        {
            LocalStorage.GetAllCategory().Add(category);
        }
    }
}
